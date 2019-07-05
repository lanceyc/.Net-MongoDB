using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using MongoDB.Bson;
using MongoDB.Driver;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var connStr = "mongodb://127.0.0.1:27017/?safe=true";
            //var client = new MongoClient(connStr);
            ////创建或打开已有数据库test
            //var database = client.GetDatabase("school");
            ////collection类似与数据库中的table，这里创建了名字为Student的collection，存放Student对象
            //var collection = database.GetCollection<Student>("Student");


            #region 查询数据
            //var filter = Builders<Student>.Filter.Eq("isdelete", "0");
            //var result = collection.Find(filter).ToList();
            #endregion

            #region 插入数据
            //Student entity = new Student();
            //entity.name = "永夜";
            //entity.age = "90";
            //entity.phone = "1371208093";
            //entity.size = "20";
            //entity.remark = "由C#添加数据至Mongodb";
            //entity.isdelete = "0";
            //collection.InsertOne(entity); 
            #endregion

            #region 修改数据
            //单个条件
            //var filter = Builders<Student>.Filter.Eq("_id", ObjectId.Parse("5d1b1b4f2f5f004dbafa6db3"));
            //var update = Builders<Student>.Update.Set("name", "尼古拉斯.渣si");
            //var result = collection.UpdateOne(filter, update);


            //多个条件
            //var buildres = Builders<Student>.Filter;
            //var filter = buildres.Eq("_id",ObjectId.Parse("5d1b1b4f2f5f004dbafa6db3")) & buildres.Eq("isdelete", "0");
            //var update = Builders<Student>.Update.Set("age", "500").Set("phone", "55822"); 
            //var result = collection.UpdateMany(filter, update);
            //if (result.ModifiedCount > 0)
            //{
            //    Console.Write("修改成功！");
            //}
            //else
            //{
            //    Console.Write("修改失败！");
            //}
            #endregion

            #region 删除数据
            //var filter=Builders<Student>.Filter.Eq("_id",ObjectId.Parse("5d1b1b4f2f5f004dbafa6db3"));
            //var result= collection.DeleteOne(filter);
            //if (result.DeletedCount>0)
            //{
            //    Console.Write("删除成功");
            //}
            //else
            //{
            //    Console.Write("删除失败");
            //} 
            #endregion


            MongoDbHelper<Student> mongdb = new MongoDbHelper<Student>();

            #region 添加数据
            //Student entity = new Student();
            //entity.name = "测试";
            //entity.age = "500";
            //entity.phone = "666666";
            //entity.size = "999";
            //entity.remark = "测试备注";
            //entity.isdelete = "0";
            //mongdb.Insert(entity); 
            #endregion

            #region 修改数据
            //string id = "5d1c43ac925ea71a4822addc";
            //object updateField = new
            //{
            //    name = "老房"
            //};
            //bool flag = mongdb.Modify(id, updateField); 
            #endregion

            #region 删除数据
            //bool flag=  mongdb.Delete(s => s._id ==ObjectId.Parse("5d1c43ac925ea71a4822addc")); 
            #endregion

            #region 查询数据
            //var dataList=mongdb.QueryAll(s => s.isdelete.Equals("0")); 
            #endregion

            #region 批量添加数据
            //List<Student> list = new List<Student>();
            //list.Add(new Student()
            //{
            //    name = "第一",
            //    age = "120",
            //    phone = "556655",
            //    size = "32",
            //    remark = "批量数据测试添加1",
            //    isdelete = "0"
            //});
            //list.Add(new Student()
            //{
            //    name = "第二",
            //    age = "120",
            //    phone = "556655",
            //    size = "32",
            //    remark = "批量数据测试添加2",
            //    isdelete = "0"
            //});
            //list.Add(new Student()
            //{
            //    name = "第三",
            //    age = "120",
            //    phone = "456456",
            //    size = "3",
            //    remark = "批量数据测试添加3",
            //    isdelete = "0"
            //});
            //list.Add(new Student()
            //{
            //    name = "第四",
            //    age = "120",
            //    phone = "7897",
            //    size = "3",
            //    remark = "批量数据测试添加4",
            //    isdelete = "0"
            //});
            //mongdb.InsertBatch(list); 
            #endregion

            #region 批量删除数据
            // List<ObjectId> list = new List<ObjectId>();
            // list.Add(new ObjectId("5d1c517a925ea71778556c23"));
            // list.Add(new ObjectId("5d1c517a925ea71778888c24"));
            //var flag= mongdb.DeleteBatch(list); 
            #endregion

            #region 修改数据
            //Student entity = new Student()
            //{
            //    name = "第一",
            //    age = "120",
            //    phone = "556655",
            //    size = "32",
            //    remark = "批量数据测试添加1",
            //    isdelete = "0"
            //};
            //mongdb.Update(s => s._id == ObjectId.Parse("5d1c517a925ea71778556c24"), entity); 
            #endregion

            Console.Write("操作完成！");
            Console.ReadKey();

        }
    }

    public class Student
    {
        public ObjectId _id { get; set; }
        public string name { get; set; }
        public string age { get; set; }
        public string phone { get; set; }
        public string size { get; set; }
        public string remark { get; set; }
        public string isdelete { get; set; }
    }

}
