using System;
using ClashOfClans.Core.Buildings;
using ClashOfClans.Core.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClashOfClansTest.Exercise_2.Q2
{
    [TestClass]
    public class WhenUnderAttack
    {
        [TestMethod]
        public void With_10000_OffensiveHitpoints_Then_A_Dragon_Dies_And_Shouts_His_Last_Message()
        {
            var dragonUnit = BlackTrainingCamp.ProduceUnit(UnitType.Dragon);

            dragonUnit.ReceiveHit(2000);

            Assert.IsTrue(dragonUnit.DefensiveHitpoints > 0);
            Assert.IsFalse(!string.IsNullOrEmpty(dragonUnit.LastMessageBeforeDying));

            dragonUnit.ReceiveHit(8000);

            Assert.IsTrue(dragonUnit.DefensiveHitpoints <=0);
            Assert.IsTrue(dragonUnit.LastMessageBeforeDying == Dragon.LastMessage);
        }
        
        [TestMethod]
        public void With_4501_OffensiveHitpoints_Then_A_Giant_Dies_And_Shouts_His_Last_Message()
        {
            var giantUnit = BlueTrainingCamp.ProduceGiant();

            giantUnit.ReceiveHit(4501);

            Assert.IsTrue(giantUnit.DefensiveHitpoints <= 0);
            Assert.IsTrue(giantUnit.LastMessageBeforeDying == Giant.LastMessage);
        }

        [TestMethod]
        public void With_1300_OffensiveHitpoints_Then_A_Miner_Dies_And_Shouts_His_Last_Message()
        {
            var minerUnit = BlueTrainingCamp.ProduceMiner();

			minerUnit.ReceiveHit(1300);

            Assert.IsTrue(minerUnit.DefensiveHitpoints <= 0);
            Assert.IsTrue(minerUnit.LastMessageBeforeDying.ToLowerInvariant() == Miner.LastMessage);
        }

        [TestMethod]
        public void With_400_OffensiveHitpoints_Then_A_Bomber_Dies_And_Shouts_His_Last_Message()
        {
            var bomberUnit = BlueTrainingCamp.ProduceBomber();
            var expectedMessage = Bomber.LastMessage;

            bomberUnit.ReceiveHit(400);

            Assert.IsTrue(bomberUnit.DefensiveHitpoints <= 0);
            Assert.IsTrue(string.Equals(bomberUnit.LastMessageBeforeDying, expectedMessage, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
