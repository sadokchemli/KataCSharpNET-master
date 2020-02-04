using System;
using ClashOfClans.Core.Buildings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClashOfClansTest.Exercise_1
{
    [TestClass]
    public class WhenProducingBlackElixir
    {
        [TestMethod]
        public void And_Gems_Supplied_Are_Not_Enough_Throw_DwarfsAngryException()
        {
			Assert.ThrowsException<InvalidQuantityException>(() => BlackElixirFactory.ProduceElixir(3, 500));
			Assert.ThrowsException<InvalidQuantityException>(() => BlackElixirFactory.ProduceElixir(2, 300));
			Assert.ThrowsException<InvalidQuantityException>(() => BlackElixirFactory.ProduceElixir(15, 501));
			Assert.ThrowsException<InvalidQuantityException>(() => BlackElixirFactory.ProduceElixir(9, 500));

		}

		[TestMethod]
        public void And_BlueElixir_Supplied_Is_Not_Enough_Throw_DwarfsAngryException()
        {
			Assert.ThrowsException<DwarfsAngryException>(() => BlackElixirFactory.ProduceElixir(1, 200));
			Assert.ThrowsException<DwarfsAngryException>(() => BlackElixirFactory.ProduceElixir(1, 500));
			Assert.ThrowsException<DwarfsAngryException>(() => BlackElixirFactory.ProduceElixir(5, 100));
			Assert.ThrowsException<DwarfsAngryException>(() => BlackElixirFactory.ProduceElixir(2, 100));
		}

		[TestMethod]
        public void With_2_Gems_And_500_BlueElixir_Should_Produce_100_BlackElixir()
        {
			Assert.AreEqual(100, BlackElixirFactory.ProduceElixir(2, 500));
		}

        [TestMethod]
        public void With_5_Gems_And_200_BlueElixir_Should_Produce_100_BlackElixir()
        {
			Assert.AreEqual(100, BlackElixirFactory.ProduceElixir(5, 200));
		}


		[TestMethod]
		public void And_Quantities_Supplied_Are_Not_Exact_Multiplication_Of_Them_Throw_InvalidQuantityException()
		{
			Assert.ThrowsException<InvalidQuantityException>(() => BlackElixirFactory.ProduceElixir(2, 1500));
			Assert.ThrowsException<InvalidQuantityException>(() => BlackElixirFactory.ProduceElixir(5, 400));

		}
	}
}
