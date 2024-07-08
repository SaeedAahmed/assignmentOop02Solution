using System.Diagnostics.Metrics;
using System.Numerics;
using System;
using System.Reflection.Emit;

namespace assignmentOop02
{

    #region securityLevel
    public enum securityLevel
    {
        Guest, Developer, Secretary, DBA
    }
    #endregion


    #region pareentClass
    internal class Pareent
    {
        #region properties
        public int x { get; set; }
        public int y { get; set; } 
        #endregion

        #region constructor
        public Pareent(int _x, int _y)
        {
            x = _x;
            y = _y;
        } 
        #endregion


        #region method
        public virtual int product()
        {
            return x * y;
        }
        public override string ToString()
        {
            return $"{x} , {y}";
        } 
        #endregion

    } 
    #endregion

    #region chiildClass
    internal class Chiild : Pareent // كل حاجه parent  كدا هيورث من
    {
        #region property
        public int z { get; set; }
        #endregion

        #region constructor

        public Chiild(int _x, int _y, int _z) : base(_x, _y) /* chining constructor*/
        {
            z = _z;
        }
        #endregion

        #region method
        //  parent الموجود في method1علي  override فيه طريقتين عشان نعمل 


        // 1-virtualنخليها parent في method ان احنا نخلي ال

        //public override int product()
        //{
        //    return x * y * z;
        //}


        //2-new ودا باستخدام كلمه parent الموجوده في  method بنفس اسم method نعمل

        public new int product()//--اللي ورثتو behavior او مكتبتهاش انا خفيت ال new سواء كتبت
        {
            return x * y * z;
        }


        #endregion


    } 
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {

            #region part01

            #region struct Vs claSS
            /*
            1.Definition:
                A struct is a value type, while a class is a reference type.
 
            2. Memory Allocation:
                Structs are typically allocated on the stack, while classes are allocated on the heap.
 
            3. Default Behaviour:
                Structs are value types and are copied by value, while classes are reference types and are copied by reference.
 
            4. Inheritance:
                Structs do not support inheritance, while classes support single inheritance.
 
            5. Nullability:
                Structs cannot be null unless they are wrapped in a nullable type, while classes can be assigned a null value.
            */

            #endregion

            #region Inheritance
            //Inheritance is one of the fundamental principles in Object - Oriented Programming(OOP).In simple terms, 
            //inheritance allows you to create a new class that inherits properties and methods from an existing class
            //Chiild child = new Chiild(1, 3, 5);
            //Console.WriteLine(child.product());
            #endregion

            #region indexer
            // هndexer is a feature that allows you to interact with objects in a class as if they were an array or list
            #endregion

            #region access modifier
            /*
              
             private protected: for a class means it is similar to protected, but it will be inherited privately within the same assembly.
             If the class is outside the project, it will not be inherited

            private protected means it is private for the class itself and in inheritance, 
            it will be inherited as protected by derived classes both within and outside the assembly.


            private protected means it is internal for the class itself, but for inheritance, it will be protected if inherited within the same assembly, 
            and private if inherited outside the assembly.
             */
            #endregion

            #endregion

            #region part02


            HiringDate hireDate1 = new HiringDate(15, 7, 2023);
        HiringDate hireDate2 = new HiringDate(20, 8, 2023);
        HiringDate hireDate3 = new HiringDate(10, 6, 2023);
        Employee employee1 = new Employee(1, "ahmed", securityLevel.DBA, 5000.00m, hireDate1, "m");
        Employee employee2 = new Employee(2, "mona", securityLevel.Guest, 3000.00m, hireDate2, "f");
            Employee employee3 = new Employee(3, "saeed", securityLevel.Developer, 7000.00m, hireDate3, "m");

            Employee[] EmpArr = new Employee[3];
            EmpArr[0] = employee1;
            EmpArr[1] = employee2;
            EmpArr[2] = employee3;



            for (int i = 0; i < EmpArr.Length; i++)
            {
                Console.WriteLine(EmpArr[i]);

            } 
            #endregion

        }


    }
}
