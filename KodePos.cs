using System;
using System.Collections.Generic;
using System.Text;

class KodePos
{
    private Dictionary<string, string> tabelKodePos = new Dictionary<string, string>()
    {
        { "Batununggal", "40266" },
        { "Kujangsari", "40287" },
        { "Mengger", "40267" },
        { "Wates", "40256" },
        { "Cijaura", "40287" },
        { "Jatisari", "40286" },
        { "Margasari", "40286" },
        { "Sekejati", "40286" },
        { "Kebonwaru", "40272" },
        { "Maleer", "40274" }
    };

    public void TampilkanSemuaKodePos()
    {

        Console.WriteLine($"Kelurahan | Kodepos |");
        Console.WriteLine("---------------------------");
        foreach (var item in tabelKodePos)
        {
            Console.WriteLine($" {item.Key,-19} |  {item.Value,-16} |");
        }

    }
}
