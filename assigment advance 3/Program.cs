namespace assigment_advance_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1
            List<int> grades = new List<int>();
            grades.Add(85);
            grades.Add(92);
            grades.Add(78);
            grades.Add(95);
            grades.Add(88);
            grades.Add(70);
            grades.Add(100);
            grades.Add(65);
            Console.WriteLine(grades.Count);
            Console.WriteLine(grades.Find(n => n > 0));
            Console.WriteLine(grades.Last());
            grades.Sort();
            foreach (var item in grades)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(grades.Find(n => n > 90));
            grades.RemoveAll(n => n < 75);
            Console.WriteLine(grades.Contains(100));
            Console.WriteLine(grades.ConvertAll(n => n.ToString()));
            #endregion
            #region question 2
            SortedList<int, string> leaderboard = new SortedList<int, string>();
            leaderboard.Add(500, "ahmed");
            leaderboard.Add(200, "sara");
            leaderboard.Add(800, "ali");
            leaderboard.Add(350, "mona");
            foreach (var item in leaderboard)
            {
                Console.WriteLine($"{item.Key},{item.Value}");
            }
            Console.WriteLine(leaderboard.Keys.Contains(500));
            if (leaderboard.TryGetValue(999, out string name))
            {
                Console.Write(name);

            }
            else
            {
                Console.WriteLine("not found");
            }
            leaderboard.Remove(200);
            foreach (var item in leaderboard)
            {
                Console.WriteLine($"{item.Key},{item.Value}");
            }
            #endregion
            #region question 3
            Dictionary<string, int> phonebook = new Dictionary<string, int>();
            phonebook.Add("mohamed", 0102223333);
            phonebook.Add("ahmed", 90932048);
            phonebook.Add("fareeda", 88787878);
            phonebook.Add("ali", 7756565);
            phonebook["sayed"] = 77868686;
            try
            {
                phonebook.Add("mohamed", 444444444);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(phonebook.TryAdd("ahmed", 66666666));
            Console.WriteLine(phonebook.ContainsKey("samir"));
            foreach (var item in phonebook)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            #endregion


        }
    }
}
