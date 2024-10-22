namespace unittest_example.Models
{
    public class register
    {
        //getters and setters
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public string check_user(string name, string email, string password)
        {
            //meassage holdere
            string message = "";

            //check email
            if (email.Contains("gmail.com"))
            {
                Console.WriteLine("Hey" + name);
                //assign the message
                message = "done";

            }
            else
            {
                message = "no";
            }
            return message;
        }

    }
}
