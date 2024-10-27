namespace TUnit_Test
{
	public class Tests
	{
		[Before(Test)]
		public async Task Setup()
		{
			/* var container = new ArangoDbBuilder()
				.WithImage("arangodb:latest")
				.WithPassword("password")
				.Build();*/
			await Task.CompletedTask;
		}

		[Test]
		public async Task Test1()
		{
			await Assert.That(true).IsTrue();
		}
	}
}
