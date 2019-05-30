using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.Fundamentals
{
    [TestFixture]
    public class StackTests
    {
        private Stack<string> stack;

        [SetUp]
        public void SetUp()
        {
            stack = new Stack<string>();
        }

        [Test]
        public void Stack_Push_ArgumentIsNull_ThrowArgumentNullException()
        {
            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Stack_Count_EmptyStack_ReturnZero()
        {
            Assert.That(stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Stack_Push_ValidArgument_AddTheObjectToTheStack()
        {
            stack.Push("a");
            Assert.That(stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Stack_Pop_EmptyStack_ThrowInvalidOperationException()
        {
            Assert.That(() => stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Stack_Pop_StackWithAFewObject_ReturnObjectOnTheTop()
        {
            // this is the arrange part
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            // the act, pop returns the value of the last object
            var result = stack.Pop();
            Assert.That(result, Is.EqualTo("c"));
        }

        [Test]
        public void Stack_Pop_StackWithAFewObject_RemoveObjectOnTheTop()
        {
            // this is the arrange part
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            // the act, removse the last object in the list
            stack.Pop();
            Assert.That(stack.Count, Is.EqualTo(2));
        }

        [Test]
        public void Stack_Peek_EmptyStack_ThrowInvalidOperationException()
        {
            Assert.That(() => stack.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void Stack_Peek_StackWithAFewObjects_ReturnObjectOnTopOfTheStack()
        {
            // this is the arrange part
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            // act
            var result = stack.Peek();
            Assert.That(result, Is.EqualTo("c"));

        }

        [Test]
        public void Stack_Peek_StackWithAFewObjects_DoesNotRemoveObjectFromTheStack()
        {
            // this is the arrange part
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            // act
            stack.Peek();
            Assert.That(stack.Count, Is.EqualTo(3));
        }
    }
}
