using Project_Euler_Solution.Archives.Interfaces;
using System;
using System.Reflection;

namespace Project_Euler_Solution
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Project Euler Solution.");

            int questionNumber = Convert.ToInt32(Console.ReadLine());

            var questionAndAnswerInstance = CreateInstance<IQuestionAndAnswer>(questionNumber);
            Console.WriteLine(questionAndAnswerInstance.QuestionHeader);
            Console.WriteLine(questionAndAnswerInstance.Question);
            Console.WriteLine(questionAndAnswerInstance.Solution());

            Console.ReadKey();
        }

        public static T CreateInstance<T>(int questionNumbr) where T : class
        {
            string className = @"Project_Euler_Solution.Archives.Implementations.QuestionAndAnswer_" + questionNumbr;
            Type type = Type.GetType(className);
            return Activator.CreateInstance(type) as T;
        }
    }
}