using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace Control_RichTextBox
{
    public static class RichTextBoxUtils
    {
        private static void SetPropertyValue(RichTextBox richTextBox, DependencyProperty property, object value)
        {
            TextRange textRange = richTextBox.Selection;
            if (textRange.IsEmpty)
                return;
            textRange.ApplyPropertyValue(property, value);
        }

        private static void TogglePropertyValue(RichTextBox richTextBox, DependencyProperty property, object value, object clearValue)
        {
            TextRange textRange = richTextBox.Selection;
            if (textRange.IsEmpty)
                return;

            object currentValue = textRange.GetPropertyValue(property);
            if (currentValue.GetHashCode() == value.GetHashCode())
                textRange.ApplyPropertyValue(property, clearValue);
            else
                textRange.ApplyPropertyValue(property, value);
        }

        private static void ToggleTextDecorationsPropertyValue(RichTextBox richTextBox, TextDecorationLocation textDecorationLocation, object value)
        {
            TextRange textRange = richTextBox.Selection;
            if (textRange.IsEmpty)
                return;

            object currentValue = textRange.GetPropertyValue(Inline.TextDecorationsProperty);
            if (currentValue is TextDecorationCollection decorations
                && decorations.Any(d => d.Location == textDecorationLocation))
                textRange.ApplyPropertyValue(Inline.TextDecorationsProperty, null);
            else
                textRange.ApplyPropertyValue(Inline.TextDecorationsProperty, value);
        }


        public static void SetSelectionBold(this RichTextBox richTextBox)
        {
            TogglePropertyValue(richTextBox, TextElement.FontWeightProperty, FontWeights.Bold, FontWeights.Normal);
        }

        public static void SetSelectionItalic(this RichTextBox richTextBox)
        {
            TogglePropertyValue(richTextBox, TextElement.FontStyleProperty, FontStyles.Italic, FontStyles.Normal);
        }

        public static void SetSelectionUnderline(this RichTextBox richTextBox)
        {
            ToggleTextDecorationsPropertyValue(richTextBox, TextDecorationLocation.Underline, TextDecorations.Underline);
        }

        public static void SetSelectionStrikethrough(this RichTextBox richTextBox)
        {
            ToggleTextDecorationsPropertyValue(richTextBox, TextDecorationLocation.Strikethrough, TextDecorations.Strikethrough);
        }

        public static void SetSelectionFontSize(this RichTextBox richTextBox, double size)
        {
            SetPropertyValue(richTextBox, TextElement.FontSizeProperty, size);
        }

        public static void SetSelectionFontFamily(this RichTextBox richTextBox, FontFamily fontFamily)
        {
            SetPropertyValue(richTextBox, TextElement.FontFamilyProperty, fontFamily);
        }

        public static void SetSelectionColor(this RichTextBox richTextBox, Color color)
        {
            SetPropertyValue(richTextBox, TextElement.ForegroundProperty, new SolidColorBrush(color));
        }
    }
}
