using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VcsRental
{
    static class RentalFile
    {
        // 予告の内容を読み込むメソッド
        public static List<string> Read()
        {
            List<string> list = new List<string>();
            // ファイルが無ければそのままリターン
            if (File.Exists(@"c:\work\rental.csv") == false)
            {
                return list;
            }

            // contents.csv の読み込み
            try
            {
                using (StreamReader reader =
                    new StreamReader(@"c:\work\rental.csv", Encoding.Default))
                {
                    // ファイルを1行ずつ読み出す
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        list.Add(line);
                    }
                }
                return list;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "エラー",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return list;
            }
        }

    }
}
