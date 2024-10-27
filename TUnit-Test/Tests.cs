namespace TUnit_Test
{
	public class Tests
	{
		[Before(Test)]
		public async Task SetupTests()
		{
			/* var container = new ArangoDbBuilder()
				.WithImage("arangodb:latest")
				.WithPassword("password")
				.Build();*/
			await Task.Delay(1);

			return;
		}

		[Test]
		public async Task TestOne()
		{
			Func<bool> func = () => true;
			await Assert.That(func()).IsTrue();
		}

		[Test]
		public async Task TestTwo()
		{
			Func<bool> func = () => true;
			await Assert.That(func()).IsTrue();
		}
	}
}
