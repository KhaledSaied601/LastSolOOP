using LastAssOOP.Part01;
using LastAssOOP.Part02;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace LastAssOOP
{

    public class H : ITest
    {
        string ITest.TestName => throw new NotImplementedException();

        string Interface1.interface01Name => throw new NotImplementedException();

        string Interface1.interface01Method()
        {
            throw new NotImplementedException();
        }
    }


    internal class Program
    {
        static public void PushNotify(INotificationService notification,string recipient,string msg)
        {
            notification.SendNotification(recipient, msg);

        }

        static void Main(string[] args)
        {
            /////////////////////////////////////Part 01 /////////////////////////////////////////////////

            #region 1- What is the primary purpose of an interface in C#?

            // b) To define a blueprint for a class



            #endregion

            #region 2- Which of the following is NOT a valid access modifier for interface members in C#?

            // a) private

            #endregion

            #region 3- Can an interface contain fields in C#?

            // b) No
            #endregion

            #region 4-In C#, can an interface inherit from another interface?
            //   b) Yes, interfaces can inherit from multiple interfaces


            #endregion


            #region 5- Which keyword is used to implement an interface in a class in C#?

            // a) inherit
            #endregion

            #region 6-Can an interface contain static methods in C#?

            //ITest.TestMethod();

            // a) Yes


            #endregion

            #region 7 - In C#, can an interface have explicit access modifiers for its members?

            // a) Yes, for all members


            #endregion

            #region 8 - What is the purpose of an explicit interface implementation in C#?

            //   b) To provide a clear separation between interface and class members

            #endregion

            #region 9 - In C#, can an interface have a constructor?

            // d) Only if the constructor is static


            #endregion

            #region 10 - How can a C# class implement multiple interfaces?

            //  c) By separating interface names with commas


            #endregion


            ///////////////////////////////// Part 02 ///////////////////////////////////////////////////

            #region Question 01

            //Circle c = new Circle();
            //c.Area = 1;
            //c.DisplayShapeInfo();


            //Rectangle r = new Rectangle();
            //r.Area = 2;
            //r.DisplayShapeInfo();



            #endregion

            #region Question 02



            //IAuthenticationService authService = new BasicAuthenticationService("Khaled","123",Role.Admin);

            //Console.WriteLine(authService.AuthenticateUser("Khaled", "123")); 
            //Console.WriteLine(authService.AuthorizeUser(Role.Guest)); 

            #endregion

            #region Question 03

            //PushNotificationService service = new PushNotificationService();
            //SmsNotificationService smsNotificationService = new SmsNotificationService();
            //EmailNotificationService emailNotificationService = new EmailNotificationService();


            //PushNotify(service,"Khaled","Welcome");
            //PushNotify(smsNotificationService, "Khaled","Welcome");
            //PushNotify(emailNotificationService, "Khaled","Welcome");




            #endregion

        }
    }
}
