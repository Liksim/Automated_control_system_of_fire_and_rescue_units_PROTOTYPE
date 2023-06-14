using DocumentFormat.OpenXml.Drawing.Charts;
using System.Diagnostics;
using System.Media;

namespace Prototip.Buttons
{
    internal class TextToSpeech
    {
        public void textToSpeech(Dictionary<string, string> data) {
            // нужен запуск от имени администратора и скачанный питон

            using Process process = new Process();

            process.StartInfo.Verb = "runas";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            var pythonPath = @"C:\Users\maksi\AppData\Local\Programs\Python\Python311\python.exe";
            var args = "../../../textToSpeech.py \"" + data["address"] + ". " + data["typeOfIncident"] + ". На выезд: " + data["buttonVoicing"] + "\"";

            process.StartInfo.FileName = pythonPath;
            process.StartInfo.Arguments = string.Format("{0}", args);
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            output = output.Substring(0, output.Length - 2);
            process.WaitForExit();

            SoundPlayer player = new SoundPlayer(output);
            player.Play();

            //File.Delete(output);  // Удаляет файл, но нужно пихать в другое место, т. к. пытается удалить во время воспроизведения
        }
    }
}
