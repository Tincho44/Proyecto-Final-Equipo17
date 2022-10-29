using ClassLibrary;
using NUnit.Framework;
using Project;

namespace Tests
{
    /// <summary>
    /// Prueba de la clase <see cref="Train"/>.
    /// </summary>
    [TestFixture]
    public class UserTest
    {
        /// <summary>
        /// El tren para probar.
        /// </summary

        /// <summary>
        /// creo un user para probar.
        /// </summary>
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Prueba que el tren arranque.
        /// </summary>
        [Test]
        public void CreateUser()
        {
            Employee employee = 
            Assert.Pass();
        }

        /// <summary>
        /// Prueba que el tren se detenga.
        /// </summary>
        [Test]
        public void StopTrainTest()
        {
            Assert.NotNull(this.train);
            this.train.StartEngines();
            this.train.StopEngines();
            Assert.False(this.train.IsEngineStarted);
        }
    }
}