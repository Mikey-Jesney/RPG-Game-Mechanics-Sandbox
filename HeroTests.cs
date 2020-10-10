using NUnit.Framework;

namespace Project_Practice
{
    public class HeroTests 
    {
        [Test]
        public void Stamina_Defaultly_30()
        {
            Hero hero = new Hero();
            Assert.That(hero.Stamina, Is.EqualTo(30));
        }

        [Test]
        public void Eat_Raises_Stamina() 
        {
            Hero hero = new Hero();
            hero.Eat();
            int currentStamina = hero.Stamina;
            Assert.That(currentStamina, Is.EqualTo(100));
        }

        [Test]
        public void Health_Defaultly_30()
        {
            Hero hero = new Hero();
            int currentHealth = hero.Health;
            Assert.That(currentHealth, Is.EqualTo(30));
        }

        [Test]
        public void Heal_Raises_Health() {
            Hero hero = new Hero();
            hero.Heal();
            Assert.That(hero.Health, Is.EqualTo(100));
        }

        // Attack tests:

        [Test]
        public void Attack_Lowers_Target_Health()
        {
            Hero hero = new Hero();
            Hero target = new Hero();

            hero.Attack(target);
            Assert.That(target.Health, Is.EqualTo(25));
        }

        [Test]
        public void Attack_Lowers_Target_Health_By_5() 
        {
            Hero hero = new Hero();
            Hero target = new Hero();
            int previousHealth = target.Health;
            hero.Attack(target);
            int currentHealth = target.Health; 
            Assert.That(currentHealth, Is.EqualTo(previousHealth - 5));
        }

        [Test]
        public void Die_When_Health_Reaches_Zero_or_Below()
        {
            Hero hero = new Hero();
            Character Kieran = new Character();
            hero.Attack(Kieran);
            hero.Attack(Kieran);
            hero.Attack(Kieran);
            hero.Attack(Kieran);
            hero.Attack(Kieran);
            hero.Attack(Kieran);
            Assert.That(Kieran.IsDead, Is.True);
        }

        // Attack lowers health of target by hero.strength

    }
}