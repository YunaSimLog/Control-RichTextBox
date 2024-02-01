﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Control_RichTextBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // TextRange를 이용하여 텍스트를 추가하기
            TextRange textRange = new TextRange(richTextBox1.Document.ContentStart, richTextBox1.Document.ContentEnd);
            textRange.Text = "안녕하세요. 심유나입니다.";
        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            // TextRange를 이용하여 속성을 추가하기
            TextRange textRange = richTextBox1.Selection;
            textRange.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Bold);
            textRange.ApplyPropertyValue(TextElement.ForegroundProperty, new SolidColorBrush(Colors.HotPink));

            //// Paragraph을 이용한 사용법
            //Paragraph paragraph = new Paragraph();
            //Run run = new Run("안녕하세요.");
            //Run run2 = new Run("심유나") { Foreground = Brushes.HotPink, FontWeight = FontWeights.Bold };
            //Run run3 = new Run("입니다.");
            //paragraph.Inlines.Add(run);
            //paragraph.Inlines.Add(run2);
            //paragraph.Inlines.Add(run3);
            //FlowDocument flowDocument = new FlowDocument();
            //flowDocument.Blocks.Add(paragraph);

            //richTextBox1.Document = flowDocument;
        }

        private void btnBold_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnItalic_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnUnderline_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnStrikethrough_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnFontSize_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnFontFamily_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnColor_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnCaretBrush_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnImage_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnRTFExport_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnRTFImport_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
