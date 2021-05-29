using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PunchData_Builder
{
    public class PunchData
    {
        public struct PE_Struct
        {
            public int ItemId { get; set; }
            public short EffectId { get; set; }
        }
        public List<PE_Struct> Items { get; } = new List<PE_Struct>();
        public byte Version = 0x1;

        public void AddEffectToList()
        {
            Items.Add(new PE_Struct() { ItemId = 18, EffectId = 0 });
            Items.Add(new PE_Struct() { ItemId = 138, EffectId = 1 });
            Items.Add(new PE_Struct() { ItemId = 366, EffectId = 2 });
            Items.Add(new PE_Struct() { ItemId = 1464, EffectId = 2 });
            Items.Add(new PE_Struct() { ItemId = 472, EffectId = 3 });
            Items.Add(new PE_Struct() { ItemId = 574, EffectId = 4 });
            Items.Add(new PE_Struct() { ItemId = 768, EffectId = 5 });
            Items.Add(new PE_Struct() { ItemId = 900, EffectId = 6 });
            Items.Add(new PE_Struct() { ItemId = 910, EffectId = 7 });
            Items.Add(new PE_Struct() { ItemId = 930, EffectId = 8 });
            Items.Add(new PE_Struct() { ItemId = 1016, EffectId = 9 });
            Items.Add(new PE_Struct() { ItemId = 1204, EffectId = 10 });
            Items.Add(new PE_Struct() { ItemId = 1378, EffectId = 11 });
            Items.Add(new PE_Struct() { ItemId = 1440, EffectId = 12 });
            Items.Add(new PE_Struct() { ItemId = 1484, EffectId = 13 });
            Items.Add(new PE_Struct() { ItemId = 1512, EffectId = 14 });
            Items.Add(new PE_Struct() { ItemId = 1542, EffectId = 15 });
            Items.Add(new PE_Struct() { ItemId = 1576, EffectId = 16 });
            Items.Add(new PE_Struct() { ItemId = 1676, EffectId = 17 });
            Items.Add(new PE_Struct() { ItemId = 1710, EffectId = 18 });
            Items.Add(new PE_Struct() { ItemId = 1748, EffectId = 19 });
            Items.Add(new PE_Struct() { ItemId = 1780, EffectId = 20 });
            Items.Add(new PE_Struct() { ItemId = 1782, EffectId = 21 });
            Items.Add(new PE_Struct() { ItemId = 1804, EffectId = 22 });
            Items.Add(new PE_Struct() { ItemId = 1868, EffectId = 23 });
            Items.Add(new PE_Struct() { ItemId = 1874, EffectId = 24 });
            Items.Add(new PE_Struct() { ItemId = 1946, EffectId = 25 });
            Items.Add(new PE_Struct() { ItemId = 1952, EffectId = 26 });
            Items.Add(new PE_Struct() { ItemId = 1956, EffectId = 27 });
            Items.Add(new PE_Struct() { ItemId = 1748, EffectId = 28 });
            Items.Add(new PE_Struct() { ItemId = 2908, EffectId = 29 });
            Items.Add(new PE_Struct() { ItemId = 6312, EffectId = 29 });
            Items.Add(new PE_Struct() { ItemId = 8554, EffectId = 29 });
            Items.Add(new PE_Struct() { ItemId = 1980, EffectId = 30 });
            Items.Add(new PE_Struct() { ItemId = 2066, EffectId = 31 });
            Items.Add(new PE_Struct() { ItemId = 2212, EffectId = 32 });
            Items.Add(new PE_Struct() { ItemId = 2218, EffectId = 33 });
            Items.Add(new PE_Struct() { ItemId = 2220, EffectId = 34 });
            Items.Add(new PE_Struct() { ItemId = 2266, EffectId = 35 });
            Items.Add(new PE_Struct() { ItemId = 2386, EffectId = 36 });
            Items.Add(new PE_Struct() { ItemId = 2388, EffectId = 37 });
            Items.Add(new PE_Struct() { ItemId = 2450, EffectId = 38 });
            Items.Add(new PE_Struct() { ItemId = 2476, EffectId = 39 });
            Items.Add(new PE_Struct() { ItemId = 4748, EffectId = 40 });
            Items.Add(new PE_Struct() { ItemId = 2512, EffectId = 41 });
            Items.Add(new PE_Struct() { ItemId = 2572, EffectId = 42 });
            Items.Add(new PE_Struct() { ItemId = 2596, EffectId = 43 });
            Items.Add(new PE_Struct() { ItemId = 2720, EffectId = 44 });
            Items.Add(new PE_Struct() { ItemId = 2752, EffectId = 45 });
            Items.Add(new PE_Struct() { ItemId = 2754, EffectId = 46 });
            Items.Add(new PE_Struct() { ItemId = 2756, EffectId = 47 });
            Items.Add(new PE_Struct() { ItemId = 2802, EffectId = 49 });
            Items.Add(new PE_Struct() { ItemId = 2866, EffectId = 50 });
            Items.Add(new PE_Struct() { ItemId = 2876, EffectId = 51 });
            Items.Add(new PE_Struct() { ItemId = 2878, EffectId = 52 });
            Items.Add(new PE_Struct() { ItemId = 2880, EffectId = 52 });
            Items.Add(new PE_Struct() { ItemId = 2906, EffectId = 53 });
            Items.Add(new PE_Struct() { ItemId = 2886, EffectId = 54 });
            Items.Add(new PE_Struct() { ItemId = 2890, EffectId = 55 });
            Items.Add(new PE_Struct() { ItemId = 3066, EffectId = 57 });
            Items.Add(new PE_Struct() { ItemId = 3124, EffectId = 58 });
            Items.Add(new PE_Struct() { ItemId = 3168, EffectId = 59 });
            Items.Add(new PE_Struct() { ItemId = 3214, EffectId = 60 });
            Items.Add(new PE_Struct() { ItemId = 9194, EffectId = 60 });
            Items.Add(new PE_Struct() { ItemId = 7408, EffectId = 61 });
            Items.Add(new PE_Struct() { ItemId = 3274, EffectId = 62 });
            Items.Add(new PE_Struct() { ItemId = 3300, EffectId = 64 });
            Items.Add(new PE_Struct() { ItemId = 3418, EffectId = 65 });
            Items.Add(new PE_Struct() { ItemId = 3476, EffectId = 66 });
            Items.Add(new PE_Struct() { ItemId = 3686, EffectId = 68 });
            Items.Add(new PE_Struct() { ItemId = 3716, EffectId = 69 });
            Items.Add(new PE_Struct() { ItemId = 4290, EffectId = 71 });
            Items.Add(new PE_Struct() { ItemId = 4474, EffectId = 72 });
            Items.Add(new PE_Struct() { ItemId = 4464, EffectId = 73 });
            Items.Add(new PE_Struct() { ItemId = 4746, EffectId = 75 });
            Items.Add(new PE_Struct() { ItemId = 4778, EffectId = 76 });
            Items.Add(new PE_Struct() { ItemId = 6026, EffectId = 76 });
            Items.Add(new PE_Struct() { ItemId = 4996, EffectId = 77 });
            Items.Add(new PE_Struct() { ItemId = 4840, EffectId = 78 });
            Items.Add(new PE_Struct() { ItemId = 5206, EffectId = 79 });
            Items.Add(new PE_Struct() { ItemId = 5480, EffectId = 80 });
            Items.Add(new PE_Struct() { ItemId = 6110, EffectId = 81 });
            Items.Add(new PE_Struct() { ItemId = 6308, EffectId = 82 });
            Items.Add(new PE_Struct() { ItemId = 6310, EffectId = 83 });
            Items.Add(new PE_Struct() { ItemId = 6298, EffectId = 84 });
            Items.Add(new PE_Struct() { ItemId = 6756, EffectId = 85 });
            Items.Add(new PE_Struct() { ItemId = 7044, EffectId = 86 });
            Items.Add(new PE_Struct() { ItemId = 6892, EffectId = 87 });
            Items.Add(new PE_Struct() { ItemId = 7088, EffectId = 89 });
            Items.Add(new PE_Struct() { ItemId = 7098, EffectId = 90 });
            Items.Add(new PE_Struct() { ItemId = 7192, EffectId = 91 });
            Items.Add(new PE_Struct() { ItemId = 7136, EffectId = 92 });
            Items.Add(new PE_Struct() { ItemId = 3166, EffectId = 93 });
            Items.Add(new PE_Struct() { ItemId = 7216, EffectId = 94 });
            Items.Add(new PE_Struct() { ItemId = 7196, EffectId = 95 });
            Items.Add(new PE_Struct() { ItemId = 7392, EffectId = 96 });
            Items.Add(new PE_Struct() { ItemId = 7384, EffectId = 98 });
            Items.Add(new PE_Struct() { ItemId = 7414, EffectId = 99 });
            Items.Add(new PE_Struct() { ItemId = 7402, EffectId = 100 });
            Items.Add(new PE_Struct() { ItemId = 7424, EffectId = 101 });
            Items.Add(new PE_Struct() { ItemId = 7488, EffectId = 103 });
            Items.Add(new PE_Struct() { ItemId = 7586, EffectId = 104 });
            Items.Add(new PE_Struct() { ItemId = 7650, EffectId = 105 });
            Items.Add(new PE_Struct() { ItemId = 6804, EffectId = 106 });
            Items.Add(new PE_Struct() { ItemId = 7568, EffectId = 107 });
            Items.Add(new PE_Struct() { ItemId = 7570, EffectId = 107 });
            Items.Add(new PE_Struct() { ItemId = 7572, EffectId = 107 });
            Items.Add(new PE_Struct() { ItemId = 7574, EffectId = 107 });
            Items.Add(new PE_Struct() { ItemId = 7668, EffectId = 108 });
            Items.Add(new PE_Struct() { ItemId = 7660, EffectId = 109 });
            Items.Add(new PE_Struct() { ItemId = 7736, EffectId = 111 });
            Items.Add(new PE_Struct() { ItemId = 9116, EffectId = 111 });
            Items.Add(new PE_Struct() { ItemId = 9118, EffectId = 111 });
            Items.Add(new PE_Struct() { ItemId = 9120, EffectId = 111 });
            Items.Add(new PE_Struct() { ItemId = 9122, EffectId = 111 });
            Items.Add(new PE_Struct() { ItemId = 7836, EffectId = 112 });
            Items.Add(new PE_Struct() { ItemId = 7838, EffectId = 112 });
            Items.Add(new PE_Struct() { ItemId = 7840, EffectId = 112 });
            Items.Add(new PE_Struct() { ItemId = 7842, EffectId = 112 });
            Items.Add(new PE_Struct() { ItemId = 7950, EffectId = 113 });
            Items.Add(new PE_Struct() { ItemId = 8002, EffectId = 114 });
            Items.Add(new PE_Struct() { ItemId = 8022, EffectId = 116 });
            Items.Add(new PE_Struct() { ItemId = 8036, EffectId = 118 });
            Items.Add(new PE_Struct() { ItemId = 8038, EffectId = 120 });
            Items.Add(new PE_Struct() { ItemId = 8816, EffectId = 128 });
            Items.Add(new PE_Struct() { ItemId = 8818, EffectId = 128 });
            Items.Add(new PE_Struct() { ItemId = 8820, EffectId = 128 });
            Items.Add(new PE_Struct() { ItemId = 8822, EffectId = 128 });
            Items.Add(new PE_Struct() { ItemId = 8910, EffectId = 129 });
            Items.Add(new PE_Struct() { ItemId = 8942, EffectId = 130 });
            Items.Add(new PE_Struct() { ItemId = 8944, EffectId = 131 });
            Items.Add(new PE_Struct() { ItemId = 8432, EffectId = 132 });
            Items.Add(new PE_Struct() { ItemId = 8434, EffectId = 132 });
            Items.Add(new PE_Struct() { ItemId = 8436, EffectId = 132 });
            Items.Add(new PE_Struct() { ItemId = 8438, EffectId = 132 });
            Items.Add(new PE_Struct() { ItemId = 8950, EffectId = 132 });
            Items.Add(new PE_Struct() { ItemId = 8960, EffectId = 134 });
            Items.Add(new PE_Struct() { ItemId = 9006, EffectId = 135 });
            Items.Add(new PE_Struct() { ItemId = 9058, EffectId = 136 });
            Items.Add(new PE_Struct() { ItemId = 9136, EffectId = 139 });
            Items.Add(new PE_Struct() { ItemId = 9138, EffectId = 140 });
            Items.Add(new PE_Struct() { ItemId = 9236, EffectId = 140 });
            Items.Add(new PE_Struct() { ItemId = 9410, EffectId = 150 });
            Items.Add(new PE_Struct() { ItemId = 9462, EffectId = 151 });
            //8946 Storm Breaker
            /*Unused-List
             * 48
             * 56
             * 63
             * 88
             * 97
             * 102
             * 110
             * 115
             * 117
             * 119
             * 121-127
             * 133
             * 141-144
            */
            Console.WriteLine($"[+] Successfully added {Items.Count} effects to list...");
        }
        public void Build()
        {
            if (!Directory.Exists("output"))
                Directory.CreateDirectory("output");
            var Path = "output/punch_data.dat";
            using var fs = File.OpenWrite(Path);
            using var bs = new BinaryWriter(fs);

            bs.Write(Version);
            bs.Write(Items.Count);
            foreach (var item in Items)
            {
                bs.Write(item.ItemId);
                bs.Write(item.EffectId);
            }
            bs.Close(); fs.Close();
            Console.WriteLine($"[+] Successfully on writting punch_data.dat");
        }
    }
}
