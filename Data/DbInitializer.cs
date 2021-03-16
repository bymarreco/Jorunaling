using Journaling.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Journaling.Data
{
    public class DbInitializer
    {
        public static void Initialize(JournalingContext context)
        {
            context.Database.EnsureCreated();

            if (context.Questions.Any())
            {
                return;
            }

            var questions = new Question[]
            {
                new Question{Descricao="Pelo que você é grato?"}
            };
            foreach(Question q in questions)
            {
                context.Questions.Add(q);
            }
            context.SaveChanges();
        }
    }
}
