using System;
using System.Diagnostics;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;


namespace CustomerSystem.Build {
    public class GetGitCommitIdTask : Task {
        [Output] public string CommitId { get; set; }

        public override bool Execute() {
            Console.WriteLine("Test custom msbuild Task");

            // 创建一个新的进程来运行 Git 命令
            var process = new Process {
                StartInfo = new ProcessStartInfo {
                    FileName = "cmd.exe",
                    Arguments = "/C git rev-parse HEAD",  // 使用 git 获取当前 commit id
                    RedirectStandardOutput = true,       // 重定向标准输出
                    RedirectStandardError = true,        // 重定向标准错误
                    UseShellExecute = false,             // 必须设置为 false 以重定向输出
                    CreateNoWindow = true               // 不显示命令行窗口
                }
            };

            try {
                // 启动进程
                process.Start();

                // 异步读取输出
                string output = process.StandardOutput.ReadToEnd().Trim();

                // 获取标准错误输出，便于调试
                string errorOutput = process.StandardError.ReadToEnd().Trim();

                process.WaitForExit();  // 等待进程结束

                // 如果有错误输出，则记录并返回失败
                if (!string.IsNullOrEmpty(errorOutput)) {
                    Console.WriteLine("Error executing git command: " + errorOutput);
                    return false;
                }

                // 赋值 CommitId 并记录
                CommitId = output;
                Console.WriteLine("Commit ID: " + CommitId);

                // 如果获取了有效的 CommitId，则返回 true
                return !string.IsNullOrEmpty(CommitId);
            } catch (Exception ex) {
                // 捕获异常并记录
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
    }
}
