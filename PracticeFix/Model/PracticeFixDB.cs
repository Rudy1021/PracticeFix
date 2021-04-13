using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.IO;//建立file功能
using PracticeFix;

namespace PracticeFix.Model
{
    public class PracticeFixDB
    {
        static SQLiteAsyncConnection practiceFixDataBase;//定義dataBase資料庫

        public PracticeFixDB(string dbpath)
        {
            //dbpath = Path.Combine(FileSystem.)
            practiceFixDataBase = new SQLiteAsyncConnection(dbpath);
            practiceFixDataBase.CreateTableAsync<FAB1> ().Wait();
        }

        
        public Task<List<FAB1>> GetPracticeFixAsync()
        {
            //get all FAB1.
            return practiceFixDataBase.Table<FAB1>().ToListAsync();

            /*第二種寫法 GetPracticeFixNotDoneAsync*/
            //return practiceFixDataBase.QueryAsync<PracticeFix>("select * from [PracticeFix] where [Id] = 0");
        }

        public Task<int> SavePracticeFixAsync(FAB1 practiceFix)
        {
            if (practiceFix.Item_Id != 0)
            {
                //update existing FAB1
                return practiceFixDataBase.UpdateAsync(practiceFix);
            }
            else
            {
                //save a new FAB1
                return practiceFixDataBase.UpdateAsync(practiceFix);
            }
        }

        public Task<int> DeletePracticeFixAsync(FAB1 practiceFix)
        {
            //delete existing FAB1
            return practiceFixDataBase.DeleteAsync(practiceFix);
        }
    }
}
