using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FontChecker
{
    public static class Fonts
    {
        public static List<string> ToList(string fonts)
        {
            var ret = new List<string>();
            using(var reader = new StringReader(fonts)) {
                while(reader.Peek() >= 0) {
                    ret.Add(reader.ReadLine());
                }
            }
            return ret;
        }

        public static List<string> GetInstalledFonts()
        {

            var fonts = new InstalledFontCollection();
            var ret = new List<string>();
            foreach(var font in fonts.Families) {
                ret.Add(font.Name);
            }
            return ret;
        }

        public const string Win7=
@"Arial
Calibri
Cambria
Candara
Comic Sans MS
Consolas
Constantia
Corbel
Courier New
Ebrima
Franklin Gothic Medium
Gabriola
Georgia
Impact
Leelawadee UI
Lucida Console
Lucida Sans Unicode
Malgun Gothic
Meiryo UI
Microsoft JhengHei
Microsoft Sans Serif
MingLiU-ExtB
PMingLiU-ExtB
Mongolian Baiti
ＭＳ ゴシック
ＭＳ Ｐゴシック
MS UI Gothic
ＭＳ 明朝
ＭＳ Ｐ明朝
Microsoft YaHei
Microsoft Yi Baiti
MV Boli
Palatino Linotype
Segoe Print
Segoe Script
Segoe UI
Sylfaen
Symbol
Tahoma
Times New Roman
Trebuchet MS
Verdana
Webdings
Microsoft Himalaya
Microsoft New Tai Lue
Microsoft PhagsPa
SimSun
NSimSun
SimSun-ExtB
Microsoft Tai Le";

        public const string Win10=
@"Arial
Calibri
Cambria
Candara
Comic Sans MS
Consolas
Constantia
Corbel
Courier New
Ebrima
FixedSys
Franklin Gothic Medium
Gabriola
Gadugi
Georgia
Impact
Javanese Text
Leelawadee UI
Lucida Console
Lucida Sans Unicode
Malgun Gothic
Meiryo UI
メイリオ
Microsoft Himalaya
Microsoft JhengHei
Microsoft JhengHei UI
Microsoft New Tai Lue
Microsoft PhagsPa
Microsoft Sans Serif
Microsoft Tai Le
Microsoft YaHei
Microsoft YaHei UI
Microsoft Yi Baiti
MingLiU_HKSCS-ExtB
MingLiU-ExtB
PMingLiU-ExtB
Modern
Mongolian Baiti
ＭＳ Ｐゴシック
MS UI Gothic
ＭＳ ゴシック
ＭＳ Ｐ明朝
ＭＳ 明朝
Microsoft Sans Serif
MS Serif
MV Boli
Myanmar Text
Nirmala UI
NSimSun
SimSun
Palatino Linotype
Roman
Script
Segoe MDL2 Assets
Segoe Print
Segoe Script
Segoe UI
Segoe UI Emoji
Segoe UI Historic
Segoe UI Symbol
SimSun-ExtB
Sitka Banner
Sitka Display
Sitka Heading
Sitka Small
Sitka Subheading
Sitka Text
Small Fonts
Sylfaen
Symbol
System
Tahoma
Terminal
Times New Roman
Trebuchet MS
Verdana
Webdings
Wingdings
Yu Gothic UI
游ゴシック
游明朝";
    }
}
