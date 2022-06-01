using System;

namespace Class____try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Esas Tapsiriq Metodlar
            // String metodlari *******************************************************************************************

            string text = "deyisenyazilar";
            //Console.WriteLine(text.ToUpper());     // toUpper
            //Console.WriteLine(text.ToLower());     // toLower

            string copyText = String.Copy(text);
            //Console.WriteLine( text + copyText);   // copy 

            /*Console.WriteLine(text.Contains("xt"));*/   // Contains

            string sentence = "salam necesiz";
            //bool check = sentence.EndsWith("necesiz");  // EndsWith
            //Console.WriteLine(check);

            //bool check1 = sentence.StartsWith("Salam");  // StartsWith
            //Console.WriteLine(check1);

            //Console.WriteLine(sentence.IndexOf("necesiz"));  // IndexOf

            //Console.WriteLine(sentence.LastIndexOf("cesiz"));  // LastIndexOf

            string sentence1 = "rafet,alma,armud,heyva";
            //string[] array = sentence1.Split(',');                // Split
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            // Console.WriteLine(sentence1.Substring(2,6));          // Substring

            string text3 = "    rafet    ";

            //Console.WriteLine(text3.Trim());                        // Trim



            // Array metodlari *******************************************************************************************
            int[] copyNumb = new int[2];
            int[] numbers = { 1, 2, 3, 4, 6, 8, 53, 7, 54, -7, 7 };

            //Console.WriteLine(Array.IndexOf(numbers,53));         //  IndexOf

            //Array.Copy(numbers, 1, copyNumb, 0, 2);              // Copy
            //foreach (int item in copyNumb)
            //{
            //    Console.WriteLine(item);
            //}

            //Array.Clear(numbers, 0, 7);                         // Clear
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}



            //**************************TRY Catch******************************************

            string test;
            int digit;
            do
            {
                try
                {
                    Console.WriteLine("Cevrilecek ededi daxil edin");
                    test = Console.ReadLine();
                    digit = int.Parse(test);
                }
                catch (Exception)
                {

                    digit = 0;
                }
            } while (digit!=5);


            #endregion

            #region 3-cu Tapsiriq******************************************************************************************

            //Verilmiş string deyerinin icərisindəki ilk sözü tapıq qaytaran metod
            string text2 = "rafet,kitab";
            FirstWord(ref text2);
            Console.WriteLine(text2);
            #endregion


            #region 4-cu Tapsiriq******************************************************************************************

            //Verilmiş string dəyərin içərisində 2 söz olmasını və hər bir sözün böyük hərflə başlamasını yoxlayan metod

            Console.WriteLine(Check("rafet,Nurlan"));
            #endregion


            #region 2-cu Tapsiriq******************************************************************************************

            //Göndərilmiş string dəyərin aşğıdaki şərtləri ödəyib ödəmədiyini (bool) qaytaran metod
            //-İçində ən az 1 rəqəm olmalıdır
            //-İçində ən az 1 böyük hərf olmalıdır
            //- İçində ən az 1 kiçik hərf olmalıdır

            CheckParameter("afet4");
            #endregion


            #region 1-ci Tapsiriq******************************************************************************************
            // Verilmiş string variable-ın dəyərini içərisində hər söz arasında bir boşluq gələcək vəzyətə salan metod

            string text4 = " Salam   ,  Dunya         ,     nurlan          ,arfet";
            NewSentence(ref text4);
            Console.WriteLine(text4);
            #endregion


            #region 5-cu Tapsiriq******************************************************************************************

            int[] numbers1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            NewArr(ref numbers1, 8);
            NewArr(ref numbers1, 78);

            //foreach (var item in numbers1)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion
        }

        static void FirstWord(ref string text)
        {
           string[] arr= text.Split(',');
            for (int i = 0; i < arr.Length; i++)
            {
                text = arr[i];
                break;
            }
        }

        static bool Check(string text)
        {
           string[] newArr= text.Split(',');
            bool check = false;

            for (int i = 0; i < newArr.Length; i++)
            {
                if (newArr.Length == 2 && Char.IsUpper(newArr[i][0]))
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            return check;




        }

        
        static bool CheckParameter(string text)
        {
            int countDigit = 0;
            int countUpper = 0;
            int countLower = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsDigit(text[i]))
                {
                    countDigit++;
                }
                else if (Char.IsLower(text[i]))
                {
                    countLower++;
                }
                else if (Char.IsUpper(text[i]))
                {
                    countUpper++;
                }
            }
            if (countDigit != 0 && countLower != 0 && countUpper != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void NewSentence(ref string text)  // " salam,     dunya ;
        {
            string newText = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    newText += text[i];
                }

                
            }
            string[] newArr = newText.Split(',');

            newText = String.Join(", ", newArr);
            text = newText;


        }


        static void NewArr(ref int[] numbers ,int number)
        {
            Array.Resize(ref numbers, numbers.Length+1);

            numbers[numbers.Length-1]=number;
        }
    }

}
