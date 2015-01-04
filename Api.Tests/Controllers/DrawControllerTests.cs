using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Api.Controllers;
using Domain.Persistence.Commands;
using Api.UnitTests.Fakes;
using Domain;
using Runners;
using Domain.Persistence.Queries;

namespace Api.UnitTests.Controllers
{
    [TestClass]
    public class DrawControllerTests
    {
        private IAddDraw addDrawCommand;

        private IGetDraw getDrawQuery;

        [TestInitialize]
        public void Initialise()
        {
            this.addDrawCommand = new AddDrawCommand(500);
            this.getDrawQuery = new GetDrawQuery(new[] {
                new Draw(1, 2, Guid.NewGuid(), null, "a draw without a date"),
            });
        }

        [TestMethod]
        public void Get()
        {
            ScenarioWithResult<DrawController, Draw>
    .With(new DrawController(null, this.getDrawQuery))
    .When(c => c.Index(1))
    .Then(draw => Assert.AreEqual(1, draw.Id))
    .Then(draw => Assert.AreEqual(2, draw.DrawMasterId))
    .Then(draw => Assert.AreEqual("a draw without a date", draw.Information))
    .Then(draw => Assert.AreEqual(null, draw.DrawDate))
    .Then(draw => Assert.AreNotEqual(Guid.Empty, draw.Guid))
    .Run();
        }

        [TestMethod]
        public void Create()
        {
            var drawDate = new DateTime(2015, 1, 4, 12, 30, 0, DateTimeKind.Utc);
            ScenarioWithResult<DrawController,Draw>
                .With(new DrawController(this.addDrawCommand, null))
                .When(c => c.Create(1, "a draw", drawDate))
                .Then(draw => Assert.AreEqual(500, draw.Id))
                .Then(draw => Assert.AreEqual(1, draw.DrawMasterId))
                .Then(draw => Assert.AreEqual("a draw", draw.Information))
                .Then(draw => Assert.AreEqual(drawDate, draw.DrawDate))
                .Then(draw => Assert.AreNotEqual(Guid.Empty, draw.Guid))
                .Run();
        }
    }
}
