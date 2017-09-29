using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Datastore.V1;
using System.Collections;
using System.Windows.Forms;

namespace _300454171_Burnside__ASS2
{
    class Tasks
    {

        private DatastoreDb _db;
        private KeyFactory keyFactory;
        private string projectId; 

        public Tasks()
        {
          System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "E:\\Downloads\\Assignment01-19e48b2ce28c.json");
            projectId = "assignment01-179921";
            _db = DatastoreDb.Create(projectId);
            keyFactory = _db.CreateKeyFactory("Task");
        }
        public void AddTask(string description, string createdBy)
        {

            Entity task = new Entity()
            {
                Key = keyFactory.CreateIncompleteKey(),
                ["Description"] = new Value()
                {
                    StringValue = description,
                    ExcludeFromIndexes = true
                },
                ["Created"] = DateTime.UtcNow,
                ["CreateBy"] = new Value()
                {
                    StringValue = createdBy,
                    ExcludeFromIndexes = true
                },
                ["Done"] = false
            };
            this._db.Insert(task);
        }
       public void MarkDone(long id)
        {
            using (var transaction = _db.BeginTransaction())
            {
                Entity task = transaction.Lookup(keyFactory.CreateKey(id));
                if (task != null)
                {
                    task["done"] = true;
                    transaction.Update(task);
                }
                transaction.Commit();
                //return task != null;
            }
        }
        public void DeleteTask(long id)
        {
            _db.Delete(keyFactory.CreateKey(id));
        }
        public IEnumerable<Entity> ListTasks()
        {
            Query query = new Query("Task")
            {
                Order = { { "Created", PropertyOrder.Types.Direction.Descending } }
            };
            return _db.RunQuery(query).Entities;
        }
        public IEnumerable<string> FormatTasks(IEnumerable<Entity> tasks)
        {
            var results = new List<string>();
            foreach (Entity task in tasks)
            {
                /*var note = (bool)task["Done"] ? "Done" :
                $"Created {(DateTime)task["Created"]}";
                results.Add($"{task.Key.Path.First().Id} : " +  $"{(string)task["Description"]} + ({note})");*/
                results.Add($"{task.Key.Path[0].Id}");
            }
            return results;
        }
    }
 }


