using IronPython.Runtime.Operations;
using System.Drawing.Printing;
using Font = System.Drawing.Font;

namespace Prototip.Buttons
{
    public class Print
    {
        // Напишем обработчик события печати, который будет непосредственно отрисовывать текст на листе бумаги
        private string header1 = "";

        private void Header1Handler(object sender, PrintPageEventArgs e)
        {
            Rectangle rect = new Rectangle(0, 10, 877, 0);

            StringFormat headerFormat = new StringFormat();
            headerFormat.Alignment = StringAlignment.Center;
            headerFormat.LineAlignment = StringAlignment.Center;

            e.Graphics.DrawString(header1, new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, rect, headerFormat);
        }

        private string header2 = "";

        private void Header2Handler(object sender, PrintPageEventArgs e)
        {
            Rectangle rect = new Rectangle(0, 40, 877, 0);

            StringFormat headerFormat = new StringFormat();
            headerFormat.Alignment = StringAlignment.Center;
            headerFormat.LineAlignment = StringAlignment.Center;

            e.Graphics.DrawString(header2, new Font("Times New Roman", 12), Brushes.Black, rect, headerFormat);
        }

        private string content = "";

        private void ContentHandler(object sender, PrintPageEventArgs e)
        {
            Rectangle rect = new Rectangle(20, 60, 877, 0);

            e.Graphics.DrawString(content, new Font("Times New Roman", 12), Brushes.Black, rect);
        }

        private string signature = "";

        private void SignatureHandler(object sender, PrintPageEventArgs e)
        {
            Rectangle rect = new Rectangle(0, 195, 820, 0);

            StringFormat headerFormat = new StringFormat();
            headerFormat.Alignment = StringAlignment.Far;
            headerFormat.LineAlignment = StringAlignment.Far;

            e.Graphics.DrawString(signature, new Font("Times New Roman", 10), Brushes.Black, rect, headerFormat);
        }

        private string date = "";

        private void DateHandler(object sender, PrintPageEventArgs e)
        {
            Rectangle rect = new Rectangle(20, 200, 877, 0);

            e.Graphics.DrawString(date, new Font("Times New Roman", 12), Brushes.Black, rect);
        }

        private string note = "";

        private void NoteHandler(object sender, PrintPageEventArgs e)
        {
            Rectangle rect = new Rectangle(20, 220, 877, 0);

            e.Graphics.DrawString(note, new Font("Times New Roman", 10), Brushes.Black, rect);
        }

        public void print(Dictionary<string, string> data)
        {
            string[] dateTimeValues = data["dateOfReceipt"].Split();
            dateTimeValues[4] = dateTimeValues[4].Insert(4, " ");
            dateTimeValues[4] = dateTimeValues[4].Insert(dateTimeValues[4].Length - 4, " ");

            header1 = "Путевка для выезда на пожар (ЧС)";

            header2 = "дежурного караула (отделения) 15 ПСЧ 1 ПСО ФПС ГПС \r\nГлавного управления МЧС России по Волгоградской области\r\n";

            content = "1. Место пожара (ЧС), адрес:\t" + data["address"] + "\n";
            content += "2. Объект пожара (характер ЧС):\t" + data["typeOfIncident"] + "\n";
            content += "3. Время получения сообщения:\t" + dateTimeValues[0] + "\n";
            content += "4. Фамилия, имя, отчество (при наличии) и номер телефона заявителя:\n";
            content += "    " + data["fio"] + " " + data["number"] + "\n";

            signature = "________________________________________________________\n";
            signature += "(подпись дежурного диспетчера подразделения пожарной охраны)";

            date = dateTimeValues[4];

            note = "Примечание. Отсутствие сведений об объекте пожара и данных о заявителе не может задерживать выезд караула на пожар (ЧС)";

            // Создадим объект для печати текста
            PrintDocument printDocument = new PrintDocument();

            // Добавим в него наш обработчик события печати
            printDocument.PrintPage += Header1Handler;
            printDocument.PrintPage += Header2Handler;
            printDocument.PrintPage += ContentHandler;
            printDocument.PrintPage += SignatureHandler;
            printDocument.PrintPage += DateHandler;
            printDocument.PrintPage += NoteHandler;

            // Создадим объект, реализующий диалоговое окно с настройкой печати 
            PrintDialog printDialog = new PrintDialog();

            // Установим в диалог печати сам документ для печати
            printDialog.Document = printDocument;

            // Запускаем диалоговое окно для печати и если в нем была нажата кнопка ОК, то выполняем печать документа на принтере.
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print();
        }
    }
}
