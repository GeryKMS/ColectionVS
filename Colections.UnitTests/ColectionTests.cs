using Collections;
using NUnit.Framework;
using System;
using System.Linq;

namespace Colection.UnitTests
{
    public class ColectionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Collection_EmptyConstructor()
        {
            //Arrange new object from Clocection
            var nums = new Collection<int>();

            // Act

            //Assert
            Assert.That(nums.Count, Is.EqualTo(0), "Count property");
            Assert.That(nums.Capacity, Is.EqualTo(16), "Capacity property");
            Assert.That(nums.ToString() == "[]");
        }

        [Test]
        public void Test_Collection_ConstructorSingleItem()
        {
            //Arrange new object from Clocection
            var nums = new Collection<int>(5);

            // Act
            Assert.That(nums.Count, Is.EqualTo(1), "Count property");
            Assert.That(nums.Capacity, Is.EqualTo(16), "Capacity property");
            Assert.That(nums.ToString() == "[5]");
        }

        [Test]
        public void Test_Collection_ConstructorMultipleItem()
        {
            //Arrange new object from Clocection
            var nums = new Collection<int>(5, 6);

            // Act
            Assert.That(nums.Count, Is.EqualTo(2), "Count property");
            Assert.That(nums.Capacity, Is.EqualTo(16), "Capacity property");
            Assert.That(nums.ToString(), Is.EqualTo("[5, 6]"));
        }

        [Test]
        public void Test_Collection_Test_Collection_Add()
        {
            //Arrange new object from Clocection
            var nums = new Collection<int>();

            //Act
            nums.Add(11);

            // Assert
            Assert.That(nums.Count, Is.EqualTo(1), "Count property");
            Assert.That(nums.Capacity, Is.EqualTo(16), "Capacity property");
            Assert.That(nums.ToString(), Is.EqualTo("[11]"));
        }

        [Test]
        public void Test_Collection_AddRangeWithGrow()
        {
            // Arrange
            var nums = new Collection<int>();
            int oldCapacity = nums.Capacity;
            var newNums = Enumerable.Range(1000, 2000).ToArray();

            // Act
            nums.AddRange(newNums);
            string expectedNums = "[" + string.Join(", ", newNums) + "]";

            // Assert
            Assert.That(nums.ToString(), Is.EqualTo(expectedNums));
            Assert.That(nums.Capacity, Is.GreaterThanOrEqualTo(oldCapacity));
            Assert.That(nums.Capacity, Is.GreaterThanOrEqualTo(nums.Count));
        }

        [Test]
        public void Test_Collection_AddRange()
        {
            // Arrange
            var nums = new Collection<int>();
            var item = new int[] {5, 6, 7, 8};
            
            // Act
            nums.AddRange(item);

            // Assert
            Assert.That(nums.Count, Is.EqualTo(4), "Count property");
            Assert.That(nums.Capacity, Is.EqualTo(16), "Capacity property");
            Assert.That(nums.ToString(), Is.EqualTo("[5, 6, 7, 8]"));
        }

        [Test]
        public void Test_Collection_GetByIndex()
        {
            // Arrange
            var names = new Collection<string>("Peter", "Maria");

            // Act
            var item0 = names[0];
            var item1 = names[1];

            // Assert
            Assert.That(item0, Is.EqualTo("Peter"));
            Assert.That(item1, Is.EqualTo("Maria"));
        }

        [Test]
        public void Test_Collection_GetByInvalideIndex()
        {
            // Arrange
            var names = new Collection<int>(1, 7, 10, 12, 15);

            // Act
           

            // Assert
            Assert.That(() => { var item = names[15]; } , Throws.InstanceOf<ArgumentOutOfRangeException>());
            Assert.That(names.ToString(), Is.EqualTo("[1, 7, 10, 12, 15]"));
        }

        [Test]
        public void Test_Collection_SetByIndex()
        {
            // Arrange
            var nums = new Collection<int>();


            // Act
            nums.InsertAt(0, 5);
            nums.InsertAt(1, 21);
                        
            // Assert
            Assert.That(nums.Count, Is.EqualTo(2), "Count property");
            Assert.That(nums.Capacity, Is.EqualTo(16), "Capacity property");
            Assert.That(nums.ToString(), Is.EqualTo("[5, 21]"));
        }

        
        [Test]
        public void Test_Collection_SetBySetByInvalidIndex()
        {
            // Arrange
            var nums = new Collection<int>();


            // Act
            nums.InsertAt(0, 5);
            nums.InsertAt(1, 21);

            // Assert
            Assert.That(() => { var item = nums[15]; }, Throws.InstanceOf<ArgumentOutOfRangeException>());
            Assert.That(nums.ToString(), Is.EqualTo("[5, 21]"));
        }

        // public void Test_Collection_InsertAtStart() { … }
        // public void Test_Collection_InsertAtEnd() { … }
        // public void Test_Collection_InsertAtMiddle() { … }
        // public void Test_Collection_InsertAtWithGrow() { … }


        // public void Test_Collection_InsertAtInvalidIndex() { … }
        // public void Test_Collection_ExchangeMiddle() { … }
        // public void Test_Collection_ExchangeFirstLast() { … }
        // public void Test_Collection_ExchangeInvalidIndexes() { … }
        // public void Test_Collection_RemoveAtStart() { … }
        // public void Test_Collection_RemoveAtEnd() { … }
        // public void Test_Collection_RemoveAtMiddle() { … }
        // public void Test_Collection_RemoveAtInvalidIndex() { … }
        // public void Test_Collection_RemoveAll() { … }
        // public void Test_Collection_Clear() { … }
        // public void Test_Collection_CountAndCapacity() { … }

        [Test]
        public void Test_Collection_ToStringEmpty() 
        {
            //Arrange new object from Clocection
            var nums = new Collection<string>();

            // Act

            //Assert
            Assert.That(nums.Count, Is.EqualTo(0), "Count property");
            Assert.That(nums.Capacity, Is.EqualTo(16), "Capacity property");
            Assert.That(nums.ToString() == "[]");
        }

        [Test]
        public void Test_Collection_ToStringSingle() 
        {

            //Arrange new object from Clocection
            var nums = new Collection<string>("Georgina");

            // Act
          
            //Assert
            Assert.That(nums.Count, Is.EqualTo(1), "Count property");
            Assert.That(nums.Capacity, Is.EqualTo(16), "Capacity property");
            Assert.That(nums.ToString() == "[Georgina]");
        }
        [Test]
        public void Test_Collection_ToStringMultiple() 
        {
            //Arrange new object from Clocection
            var nums = new Collection<string>("Georgina", "Alex", "Filip", "Jon");

            // Act

            //Assert
            Assert.That(nums.Count, Is.EqualTo(4), "Count property");
            Assert.That(nums.Capacity, Is.EqualTo(16), "Capacity property");
            Assert.That(nums.ToString() == "[Georgina, Alex, Filip, Jon]");
        }
        
        [Test]
        public void Test_Collection_ToStringNestedCollections()
        {
            var names = new Collection<string>("Teddy", "Gerry");
            var nums = new Collection<int>(10, 20);
            var dates = new Collection<DateTime>();
            var nested = new Collection<object>(names, nums, dates);
            string nestedToString = nested.ToString();
            Assert.That(nestedToString,
              Is.EqualTo("[[Teddy, Gerry], [10, 20], []]"));
        }
       
        [Test]
        [Timeout(1000)]
        public void Test_Collection_1MillionItems()
        {
            const int itemsCount = 1000000;
            var nums = new Collection<int>();
            nums.AddRange(Enumerable.Range(1, itemsCount).ToArray());
            Assert.That(nums.Count == itemsCount);
            Assert.That(nums.Capacity >= nums.Count);
            for (int i = itemsCount - 1; i >= 0; i--)
                nums.RemoveAt(i);
            Assert.That(nums.ToString() == "[]");
            Assert.That(nums.Capacity >= nums.Count);
        }

        // DataDrivenTest

        [TestCase("Piter", 0, "Piter")]

        public void Test_Collection_GetByValidIndex(
            string data, int index, string expextedData)
        {
            // Arange
            var nums = new Collection<string>(data);

            // Act
            var actual = nums[index];

            // Assert
            Assert.That(actual, Is.EqualTo(expextedData));
        }

    }
}