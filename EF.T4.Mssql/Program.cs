using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.T4.Mssql
{
    class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }

        public int ClassId { get; set; }
    }

    class MyClass
    {
        public int Id { get; set; }

        public string Name { get; set; }

    }

    unsafe class Program
    {
        static int processing = 0;
        static void Main(string[] args)
        {
            try
            {
                int* vptr = null;
                *vptr = 100;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }





            var lstStudent = System.Linq.Enumerable.Range(1, 10).Select(x => new Student() { Age = x, ClassId = x % 4, Id = x, Name = "同学" + x }).ToList();

            var lstclass = System.Linq.Enumerable.Range(1, 5).Select(x => new MyClass() { Id = x, Name = "班级" + x }).ToList();

            var dict = lstclass.GroupJoin(lstStudent, x => x.Id, y => y.ClassId, (x, y) => new { x, y })
                .ToDictionary(x => x.x, x => x.y.ToList());

            while (true)
            {
                var str = System.Console.ReadLine();
                if (System.Threading.Interlocked.Exchange(ref processing, 1) != 0)
                {
                    Console.WriteLine("系统繁忙，请稍后再尝试");
                    continue;
                }
                System.Threading.ThreadPool.QueueUserWorkItem(x => {
                    Console.WriteLine("处理中....");
                    System.Threading.Thread.Sleep(5 * 1000);
                    Console.WriteLine($"你输入的内容是：{str}");
                    System.Threading.Interlocked.Exchange(ref processing, 0);
                });


            }



            //var lst = System.Linq.Enumerable.Range(1, 1 - 1).Select(x => new DateTime(2019, x, 1).ToString()).ToList();


            //double i = 123456789012345.256487987588888888;
            ////1234567890123456.7
            ////1125899906842624.3
            //while (true)
            //{
            //    if (i.ToString().ToUpper().Contains("E"))
            //        break;
            //    i=i*2.0;
            //}

            //double mr = 87.33333333333333333333333333333333333333333333;


            //DbContext dbcontext = new DbContext();
            //Table_1 ta = new Table_1() {
            //    Id = Guid.NewGuid(),
            //    TheDecimal12 = 123456.789123m,
            //    TheDecimal38 = 123456.789123m,
            //    TheDecimal4 = 56.789123m,
            //    TheFloat = mr,
            //    TheReal = 123456.789123f,
            //};

            ////double tmp =12345678901234567890123456789.1234567890123456789;
            //            //79228162514264337593543950335
            //decimal tmp = 9999999999999999.123456789012m;
            ////decimal.MaxValue
            //Table_1 maxTa = new Table_1() {
            //    Id = Guid.NewGuid(),
            //    //TheDecimal12 = (decimal)tmp,
            //    TheDecimal38 = tmp,
            //    //TheDecimal4 = (decimal)tmp,
            //    TheFloat = (double)tmp,
            //    TheReal = (float)tmp,
            //};

            ////double m = 1.25E+10;

            //decimal mintmp = 0.00000000000000000000123456m;
            //Table_1 minTa = new Table_1() {
            //     Id=Guid.NewGuid(),
            //      TheDecimal12=mintmp,
            //      TheDecimal38=mintmp,
            //       TheDecimal4=mintmp,
            //        TheFloat=(double)mintmp,
            //         TheReal=(float)mintmp
            //};

            //dbcontext.Table_1.Add(ta);

            //dbcontext.Table_1.Add(maxTa);
            //dbcontext.Table_1.Add(minTa);
            //var rt= dbcontext.SaveChanges();
        }
    }
