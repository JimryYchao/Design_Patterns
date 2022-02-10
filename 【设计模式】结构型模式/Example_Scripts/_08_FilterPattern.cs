/*
 *  设计模式结构型————过滤器模式（标准模式）
 *
 *  意图：{ 对一组对象或请求采用不同的标准分类或过滤，主要用于统一接收并过滤客
 *         户端的请求，根据过滤器的选择，将请求传送给对应的目标处理程序。}
 *
 *  动机：{ 1. 软件由多个复杂的处理流程组成，每个处理有自己独特的处理逻辑，流程
 *         不容易控制，每个流程的输出不容易得到及时的反馈，编写代码较为复杂，处
 *         理流程混乱，不容易形成体系结构，不容易进行任务的分解与分工，而且代码
 *         不容易测试及维护。
 *         
 *         2. 明确进行流程化管理时, 筛选出必要与非必要对象。}
 */

using System;
using System.Collections.Generic;

namespace Ychao.Learn.DesignPatterns.StructuralPatterns
{
    class FilterPattern
    {
        //----------------------------------------Target被过滤主体对象
        public class Person
        {
            private string name;
            public string Name => name;
            private GenderType gender;//性别
            public GenderType Gender => gender;
            private MaritalStatus maritalStatus;//婚姻状态
            public MaritalStatus Marital => maritalStatus;
            public Person(string name, GenderType gender, MaritalStatus marital)
            {
                this.gender = gender;
                this.maritalStatus = marital;
            }
            public enum GenderType
            {
                Male,
                Female,
            }
            public enum MaritalStatus
            {
                Married,
                Single
            }
        }
        //-----------------------------------------Filters过滤器实体类
        public interface IFilter
        {
            List<Person> Filter(List<Person> people);
        }
        public class MaleFilter : IFilter
        {
            List<Person> IFilter.Filter(List<Person> people)
            {
                List<Person> maleArr = new List<Person>();
                foreach (var item in people)
                {
                    if (item.Gender == Person.GenderType.Male)
                    {
                        maleArr.Add(item);
                    }
                }
                return maleArr;
            }
        }
        public class FemaleFilter : IFilter
        {
            List<Person> IFilter.Filter(List<Person> people)
            {
                List<Person> femaleArr = new List<Person>();
                foreach (var item in people)
                {
                    if (item.Gender == Person.GenderType.Female)
                    {
                        femaleArr.Add(item);
                    }
                }
                return femaleArr;
            }
        }
        public class MarriedFilter : IFilter
        {
            List<Person> IFilter.Filter(List<Person> people)
            {
                List<Person> Arr = new List<Person>();
                foreach (var item in people)
                {
                    if (item.Marital == Person.MaritalStatus.Married)
                    {
                        Arr.Add(item);
                    }
                }
                return Arr;
            }
        }
        public class SingleFilter : IFilter
        {
            List<Person> IFilter.Filter(List<Person> people)
            {
                List<Person> Arr = new List<Person>();
                foreach (var item in people)
                {
                    if (item.Marital == Person.MaritalStatus.Single)
                    {
                        Arr.Add(item);
                    }
                }
                return Arr;
            }
        }
        //---------------------------------------FilterChain
        public class AndFilterChain : IFilter
        {
            IFilter IFilter1;
            IFilter IFilter2;
            public AndFilterChain(IFilter filter1, IFilter filter2)
            {
                this.IFilter1 = filter1;
                this.IFilter2 = filter2;
            }
            List<Person> IFilter.Filter(List<Person> people)
            {
                List<Person> Arr = IFilter1.Filter(people);
                return IFilter2.Filter(Arr);
            }
        }
        public class OrFilterChain : IFilter
        {
            IFilter IFilter1;
            IFilter IFilter2;
            public OrFilterChain(IFilter filter1, IFilter filter2)
            {
                this.IFilter1 = filter1;
                this.IFilter2 = filter2;
            }
            List<Person> IFilter.Filter(List<Person> people)
            {
                List<Person> Arr1 = IFilter1.Filter(people);
                List<Person> Arr2 = IFilter2.Filter(people);

                foreach (var item in Arr2)
                {
                    if (!Arr1.Contains(item))
                    {
                        Arr1.Add(item);
                    }
                }return Arr1;
            }
        }
        //-----------------------------------------FilterManager
        public class FilterManager
        {
            IFilter maleFilter = new MaleFilter();
            IFilter femaleFilter = new FemaleFilter();
            IFilter marriedFilter = new MarriedFilter();
            IFilter singleFilter = new SingleFilter();

            IFilter maleAndMarried;
            IFilter femaleOrSingle;

            public FilterManager()
            {
                maleAndMarried = new AndFilterChain(maleFilter, marriedFilter);
                femaleOrSingle = new OrFilterChain(femaleFilter, singleFilter);
            }

            public List<Person> getMaleList(List<Person> people)
            {
                return maleFilter.Filter(people);
            }
            public List<Person> getFemaleList(List<Person> people)
            {
                return femaleFilter.Filter(people);
            }
            public List<Person> getMarriedMaleList(List<Person> people)
            {
                return maleAndMarried.Filter(people);
            }
            public List<Person> getFemaleAndSingleMale(List<Person> people)
            {
                return femaleOrSingle.Filter(people);
            }
        }
        //------------------------------------------FilterPatternDemo
        public class FlyweightPatternDemo
        {
            static void Main_(string[] args)
            {
                List<Person> persons = new List<Person>();

                persons.Add(new Person("Robert", Person.GenderType.Male, Person.MaritalStatus.Single));
                persons.Add(new Person("John", Person.GenderType.Male, Person.MaritalStatus.Married));
                persons.Add(new Person("Laura", Person.GenderType.Female, Person.MaritalStatus.Married));
                persons.Add(new Person("Diana", Person.GenderType.Female, Person.MaritalStatus.Single));
                persons.Add(new Person("Mike", Person.GenderType.Male, Person.MaritalStatus.Single));
                persons.Add(new Person("Bobby", Person.GenderType.Male, Person.MaritalStatus.Single));

                FilterManager filters = new FilterManager();

                filters.getFemaleList(persons);
                filters.getFemaleAndSingleMale(persons);
                filters.getMaleList(persons);
                filters.getMarriedMaleList(persons);
            }
        }

    }
}
