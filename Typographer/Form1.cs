using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typographer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = richTextBox_enter.Text;

            /// <summary>
            /// 
            /// Выбранные мной правила:
            /// 
            /// 2. Нельзя писать подряд более одного пробела.
            /// 
            /// 4.Кроме кавычек «ёлочек» можно использовать т.н.кавычки „лапки“: „Лапки“ Обычно используются только «ёлочки»,
            ///а кавычки лапки начинают использоваться, когда в одной конструкции находящейся в кавычках,
            ///необходимо написать другую конструкцию в кавычках. Например: Вася Пупкин сказал: «Мой хакерский никнейм „Neo“!»
            ///
            /// 6.Везде, где по правилам русского языка должно быть тире, ни в коем случае нельзя писать знак дефис,
            ///который по умолчанию доступен на клавиатуре. Символ тире задаётся конструкцией —. Например чтобы получить:
            ///«Книга — источник знания», нужно написать «Книга — источник знания».
            ///
            /// 9.Символ «плюс - минус» задаётся так: ± ненужно использовать конструкции типа «(+,−)».
            /// 
            /// + придуманные
            /// 
            /// 
            ///
            /// </summary>

            // Правило 2
            text = Regex.Replace(text, @"\s{2,}", " ");

            // Правило 9
            text = Regex.Replace(text, @"\(\+\,\-\)", "±");

            // Правило 6
            text = Regex.Replace(text, @"(\p{L})-(\p{L})", "$1—$2");

            // Правило 4 использовала регулярное выражение, которое находит кавычки «ёлочки» и
            // заменяет их на кавычки «лапки». Затем регулярное выражение ищет в тексте кавычки «лапки»
            // и заменяет их на кавычки «ёлочки», но только если они находятся внутри другой конструкции в кавычках

            // замена кавычек «ёлочек» на кавычки «лапки»
            text = Regex.Replace(text, "«", "„");
            text = Regex.Replace(text, "»", "“");

            // замена кавычек «лапок» на кавычки «ёлочки»
            text = Regex.Replace(text, "„(?<quote>[^\"]*)“", "«${quote}»");



            // Добавляем точку в конце предложения, если ее нет
            text = Regex.Replace(text, @"(?<=[^\.\?!])$", ".");

            // Нельзя начинать новый абзац с последовательности пробелов или табуляций.
            text = Regex.Replace(text, @"^\s+", "");

            // Нельзя использовать нестандартные шрифты или размеры шрифта.
            text = Regex.Replace(text, @"\<.*?\>", "");

            richTextBox_exit.Visible = true;
            button_end.Visible = true;
            richTextBox_exit.Text = text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox_exit.Clear();
            richTextBox_enter.Clear();

            richTextBox_exit.Visible = false;
            button_end.Visible = false;

        }
    }
}
