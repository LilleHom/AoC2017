using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2017
{
    class Program
    {
        static int MatrixSize = 1001;
        static int[,] matrix = new int[MatrixSize, MatrixSize];
        static int NewMatrixVal = 0;

        static void Main(string[] args)
        {
            //Day 6
            SolveDaySix();

            //Day 5
            //SolveTraverseInterrupts();

            //Day 4
            //TjekAllTokens();

            //Day 3
            //DoMatrixStuff();

            //Day 2 - P1

            //Day 2 - P2
            //Console.WriteLine(GetMinMaxDif("790	99	345	1080	32	143	1085	984	553	98	123	97	197	886	125	947")+GetMinMaxDif("302	463	59	58	55	87	508	54	472	63	469	419	424	331	337	72")+GetMinMaxDif("899	962	77	1127	62	530	78	880	129	1014	93	148	239	288	357	424")+GetMinMaxDif("2417	2755	254	3886	5336	3655	5798	3273	5016	178	270	6511	223	5391	1342	2377")+GetMinMaxDif("68	3002	3307	166	275	1989	1611	364	157	144	3771	1267	3188	3149	156	3454")+GetMinMaxDif("1088	1261	21	1063	1173	278	1164	207	237	1230	1185	431	232	660	195	1246")+GetMinMaxDif("49	1100	136	1491	647	1486	112	1278	53	1564	1147	1068	809	1638	138	117")+GetMinMaxDif("158	3216	1972	2646	3181	785	2937	365	611	1977	1199	2972	201	2432	186	160")+GetMinMaxDif("244	86	61	38	58	71	243	52	245	264	209	265	308	80	126	129")+GetMinMaxDif("1317	792	74	111	1721	252	1082	1881	1349	94	891	1458	331	1691	89	1724")+GetMinMaxDif("3798	202	3140	3468	1486	2073	3872	3190	3481	3760	2876	182	2772	226	3753	188")+GetMinMaxDif("2272	6876	6759	218	272	4095	4712	6244	4889	2037	234	223	6858	3499	2358	439")+GetMinMaxDif("792	230	886	824	762	895	99	799	94	110	747	635	91	406	89	157")+GetMinMaxDif("2074	237	1668	1961	170	2292	2079	1371	1909	221	2039	1022	193	2195	1395	2123")+GetMinMaxDif("8447	203	1806	6777	278	2850	1232	6369	398	235	212	992	7520	7304	7852	520")+GetMinMaxDif("3928	107	3406	123	2111	2749	223	125	134	146	3875	1357	508	1534	4002	4417"));

            //Day 1 - P2
            //Console.WriteLine(GetMidStrangeSum("6592822488931338589815525425236818285229555616392928433262436847386544514648645288129834834862363847542262953164877694234514375164927616649264122487182321437459646851966649732474925353281699895326824852555747127547527163197544539468632369858413232684269835288817735678173986264554586412678364433327621627496939956645283712453265255261565511586373551439198276373843771249563722914847255524452675842558622845416218195374459386785618255129831539984559644185369543662821311686162137672168266152494656448824719791398797359326412235723234585539515385352426579831251943911197862994974133738196775618715739412713224837531544346114877971977411275354168752719858889347588136787894798476123335894514342411742111135337286449968879251481449757294167363867119927811513529711239534914119292833111624483472466781475951494348516125474142532923858941279569675445694654355314925386833175795464912974865287564866767924677333599828829875283753669783176288899797691713766199641716546284841387455733132519649365113182432238477673375234793394595435816924453585513973119548841577126141962776649294322189695375451743747581241922657947182232454611837512564776273929815169367899818698892234618847815155578736875295629917247977658723868641411493551796998791839776335793682643551875947346347344695869874564432566956882395424267187552799458352121248147371938943799995158617871393289534789214852747976587432857675156884837634687257363975437535621197887877326295229195663235129213398178282549432599455965759999159247295857366485345759516622427833518837458236123723353817444545271644684925297477149298484753858863551357266259935298184325926848958828192317538375317946457985874965434486829387647425222952585293626473351211161684297351932771462665621764392833122236577353669215833721772482863775629244619639234636853267934895783891823877845198326665728659328729472456175285229681244974389248235457688922179237895954959228638193933854787917647154837695422429184757725387589969781672596568421191236374563718951738499591454571728641951699981615249635314789251239677393251756396"));

            //Day 1 - P1
            //Console.WriteLine(GetStrangeSum("6592822488931338589815525425236818285229555616392928433262436847386544514648645288129834834862363847542262953164877694234514375164927616649264122487182321437459646851966649732474925353281699895326824852555747127547527163197544539468632369858413232684269835288817735678173986264554586412678364433327621627496939956645283712453265255261565511586373551439198276373843771249563722914847255524452675842558622845416218195374459386785618255129831539984559644185369543662821311686162137672168266152494656448824719791398797359326412235723234585539515385352426579831251943911197862994974133738196775618715739412713224837531544346114877971977411275354168752719858889347588136787894798476123335894514342411742111135337286449968879251481449757294167363867119927811513529711239534914119292833111624483472466781475951494348516125474142532923858941279569675445694654355314925386833175795464912974865287564866767924677333599828829875283753669783176288899797691713766199641716546284841387455733132519649365113182432238477673375234793394595435816924453585513973119548841577126141962776649294322189695375451743747581241922657947182232454611837512564776273929815169367899818698892234618847815155578736875295629917247977658723868641411493551796998791839776335793682643551875947346347344695869874564432566956882395424267187552799458352121248147371938943799995158617871393289534789214852747976587432857675156884837634687257363975437535621197887877326295229195663235129213398178282549432599455965759999159247295857366485345759516622427833518837458236123723353817444545271644684925297477149298484753858863551357266259935298184325926848958828192317538375317946457985874965434486829387647425222952585293626473351211161684297351932771462665621764392833122236577353669215833721772482863775629244619639234636853267934895783891823877845198326665728659328729472456175285229681244974389248235457688922179237895954959228638193933854787917647154837695422429184757725387589969781672596568421191236374563718951738499591454571728641951699981615249635314789251239677393251756396"));

            Console.ReadLine();
        }
        static void SolveDaySix()
        {
            int Steps = 0;
            int[] MemoryBankList;
            var MemoryBankHistoryList = new List<string>();
            var ints = new List<int>();
            foreach (var token in System.IO.File.ReadAllLines(@"inputFiles\TextFileDay6.txt"))
            {
                ints.Add(Int32.Parse(token));
            }
            MemoryBankList = ints.ToArray();

            int NumberOfMemoryBanks = MemoryBankList.Count();
            int CurrentMemoryBankIndex = 0;
            int Spread = 0;
            int Remaining = 0;
            MemoryBankHistoryList.Add(GetBankString(MemoryBankList));
            while (MemoryBankHistoryList.Distinct().Count() == MemoryBankHistoryList.Count())
            {
                Steps++;
                CurrentMemoryBankIndex = GetFirstMaxIndex(MemoryBankList);
                Spread = MemoryBankList[CurrentMemoryBankIndex] / (NumberOfMemoryBanks - 1);
                if (Spread == 0)
                    Spread = 1;
                Remaining = MemoryBankList[CurrentMemoryBankIndex];
                MemoryBankList[CurrentMemoryBankIndex] = 0;
                while (Remaining > 0)
                {
                    if (CurrentMemoryBankIndex == NumberOfMemoryBanks - 1)
                        CurrentMemoryBankIndex = 0;
                    else
                        CurrentMemoryBankIndex++;
                    if (Spread <= Remaining)
                    {
                        MemoryBankList[CurrentMemoryBankIndex] += Spread;
                        Remaining -= Spread;
                    }
                    else
                    {
                        MemoryBankList[CurrentMemoryBankIndex] += Remaining;
                        Remaining = 0;
                    }
                }
                MemoryBankHistoryList.Add(GetBankString(MemoryBankList));
            }
            Console.WriteLine(Steps.ToString() + " rounds before dublicate was generated: " + MemoryBankHistoryList.Last());
            int ix = 0;
            while (MemoryBankHistoryList[ix] != MemoryBankHistoryList.Last())
            {
                ix++;
            }
            Console.WriteLine(String.Format("First occurence at index: {0} ({1}) - Last one at: {2} ({3})", ix, MemoryBankHistoryList[ix], MemoryBankHistoryList.Count() - 1, MemoryBankHistoryList[MemoryBankHistoryList.Count() - 1]));
            Console.WriteLine(String.Format("Answer to P2 is: {0}", MemoryBankHistoryList.Count() - 1 - ix));
        }
        static int GetFirstMaxIndex(int[] MemoryBanks)
        {
            int i = 0;
            while (MemoryBanks[i] != MemoryBanks.Max())
            {
                i++;
            }
            return i;
        }

        static string GetBankString(int[] banks)
        {
            string b = "";
            for (int i = 0; i < banks.Count(); i++)
            {
                b += banks[i] + "-";
            }
            return b;
        }
        static void SolveTraverseInterrupts()
        {
            //            int[] interruptList = new int[] { 0, 3, 0, 1, -3 };
            int[] interruptList;
            var ints = new List<int>();
            foreach (var token in System.IO.File.ReadAllLines(@"inputFiles\TextFileDay5.txt"))
            {
                ints.Add(Int32.Parse(token));
            }
            interruptList = ints.ToArray();
            Console.WriteLine(TraverseArray(interruptList));
        }
        static int TraverseArray(int[] interrupts)
        {
            int iLength = interrupts.Length;
            int steps = 0;
            int position = 0;
            while (interrupts[position] + position < iLength)
            {
                int OldPosition = position;
                position += interrupts[position];
                if (interrupts[OldPosition] > 2)
                    interrupts[OldPosition]--;
                else
                    interrupts[OldPosition]++;
                steps++;
            }
            return ++steps;
        }

        static void TjekAllTokens()
        {
            int validTokenCount = 0;

            foreach (var token in System.IO.File.ReadAllLines(@"inputFiles\TextFileDay4.txt"))
            {
                if (TjekToken(token))
                    validTokenCount++;
            }
            Console.WriteLine(validTokenCount);
        }
        static bool TjekToken(string token)
        {
            string[] tokenarray = token.Split(' ');
            for (int i = 0; i < tokenarray.Length; i++)
            {
                for (int k = 0 + i + 1; k < tokenarray.Length; k++)
                {
                    // Day 4-1                    if (tokenarray[i] == tokenarray[k])
                    // Day 4-2
                    if (SortLettersInString(tokenarray[i]) == SortLettersInString(tokenarray[k]))
                        return false;
                }
            }
            return true;
        }

        static string SortLettersInString(string unsortedStr)
        {
            Char[] tmpStr = unsortedStr.ToArray();
            Array.Sort(tmpStr);
            return new string(tmpStr);
        }

        static int GetStrangeSum(string digitString)
        {
            int sum = 0;
            int nextvalue = Int32.Parse(digitString[0].ToString());
            for (int i = digitString.Length - 1; i >= 0; i--)
            {
                int currentvalue = Int32.Parse(digitString[i].ToString());
                if (currentvalue == nextvalue)
                    sum += currentvalue;
                nextvalue = currentvalue;
            }
            return sum;
        }

        static int GetMidStrangeSum(string digitString)
        {
            int sum = 0;
            int start = digitString.Length - 1;
            int slut = digitString.Length / 2 - 1;
            for (int i = start; i > slut; i--)
            {
                if (digitString[i] == digitString[i - (digitString.Length / 2)])
                    sum += Int32.Parse(digitString[i].ToString());
            }
            return sum * 2;
        }

        static int GetMinMaxDif(string digitString)
        {
            string[] allNumbersFirst = digitString.Split('\t');
            string[] allNumbersSecond = digitString.Split('\t');
            foreach (var strNumber1 in allNumbersFirst)
            {
                int firstCheckNumber = Int32.Parse(strNumber1);
                foreach (var strNumber2 in allNumbersSecond)
                {
                    int secondCheckNumber = Int32.Parse(strNumber2);
                    if (firstCheckNumber != secondCheckNumber)
                        if ((firstCheckNumber % secondCheckNumber == 0))
                            return firstCheckNumber / secondCheckNumber;
                }
            }
            return 0;
        }

        static void CalculateSpiral(int number)
        {
            int steps = number * 2;
            int x = number;
            int y = 0 - number;
            for (int i = 0; i < steps; i++)
            {
                y++;
                Console.WriteLine(x.ToString() + " " + y.ToString());
                CalculateMatrixValue(x, y);
            }
            for (int i = 0; i < steps; i++)
            {
                x--;
                Console.WriteLine(x.ToString() + " " + y.ToString());
                CalculateMatrixValue(x, y);
            }
            for (int i = 0; i < steps; i++)
            {
                y--;
                Console.WriteLine(x.ToString() + " " + y.ToString());
                CalculateMatrixValue(x, y);
            }
            for (int i = 0; i < steps; i++)
            {
                x++;
                Console.WriteLine(x.ToString() + " " + y.ToString());
                CalculateMatrixValue(x, y);
            }
        }
        static void DoMatrixStuff()
        {
            initMatrix();
            CalculateMatrixValue(0, 0);
            for (int i = 1; i < 300; i++)
            {
                CalculateSpiral(i);
            }
        }
        static void initMatrix()
        {
            for (int x = 0; x < MatrixSize - 1; x++)
            {
                for (int y = 0; y < MatrixSize - 1; y++)
                {
                    matrix[x, y] = 0;
                }
            }
            matrix[(MatrixSize - 1) / 2, (MatrixSize - 1) / 2] = 1;
        }

        //Day3 - P2
        static void CalculateMatrixValue(int x, int y)
        {
            int offset = (MatrixSize - 1) / 2;

            int x1 = x + offset;
            int y1 = y + offset;

            matrix[x1, y1] = matrix[x1, y1] + matrix[x1 + 1, y1] + matrix[x1 + 1, y1 + 1] + matrix[x1, y1 + 1] + matrix[x1 - 1, y1 + 1] + matrix[x1 - 1, y1] + matrix[x1 - 1, y1 - 1] + matrix[x1, y1 - 1] + matrix[x1 + 1, y1 - 1];
            Console.WriteLine(matrix[x1, y1]);
            if (matrix[x1, y1] > 289326)
            {
                Console.WriteLine(String.Format("({0},{1}): {2} - Answer is: {3}", x, y, matrix[x1, y1], matrix[x1, y1]));
                Console.ReadLine();
            }
        }

        //Day3 - P1
        static void CalculateMatrixValue1(int x, int y)
        {
            int offset = (MatrixSize - 1) / 2;

            int x1 = x + offset;
            int y1 = y + offset;

            matrix[x1, y1] = ++NewMatrixVal;
            if (NewMatrixVal == 289326)
            {
                Console.WriteLine(String.Format("({0},{1}): {2} - Answer is: {3}", x, y, NewMatrixVal, Math.Abs(x) + Math.Abs(y)));
                Console.ReadLine();
            }
            Console.WriteLine(matrix[x1, y1]);
        }
    }
}
