using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Persistance
{
    public class DbInitianalizer
    {
        public static void Initianalize(NotesDbContext context) 
        { 
            context.Database.EnsureCreated();
        
        }
    }
}
