using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilities
{
    public class Utils
    {
        public class ListViewToCSV
        {
            public static void ToCSV(ListView listView, string filePath, bool includeHidden)
            {
                //make header string
                StringBuilder result = new StringBuilder();
                WriteCSVRow(result, listView.Columns.Count, i => includeHidden || listView.Columns[i].Width > 0, i => listView.Columns[i].Text);
                //export data rows
                foreach (ListViewItem listItem in listView.Items)
                    WriteCSVRow(result, listView.Columns.Count, i => includeHidden || listView.Columns[i].Width > 0, i => listItem.SubItems[i].Text);
                File.WriteAllText(filePath, result.ToString());
            }

            public static void ToCSV(ListView listView, string filePath)
            {
                //make header string
                using (StreamWriter sw = new System.IO.StreamWriter(filePath, false, System.Text.Encoding.Default))
                {
                    //ajout du titre des colonnes
                    foreach (ColumnHeader c in listView.Columns)
                        sw.Write(string.Format("{0};", c.Text));
                    sw.WriteLine("");

                    // ajout des données
                    foreach (ListViewItem item in listView.Items)
                    {
                        foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                            sw.Write(string.Format("{0};", subitem.Text));
                        sw.WriteLine("");
                    }
                }
            }
            private static void WriteCSVRow(StringBuilder result, int itemsCount, Func<int, bool> isColumnNeeded, Func<int, string> columnValue)
            {
                bool isFirstTime = true;
                for (int i = 0; i < itemsCount; i++)
                {
                    if (!isColumnNeeded(i))
                        continue;
                    if (!isFirstTime)
                        result.Append(",");
                    isFirstTime = false;
                    result.Append(String.Format("\"{0}\"", columnValue(i)));
                }
                result.AppendLine();
            }
        }
    }
}
