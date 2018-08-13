namespace SA.GA.WebApplication.Controllers
{
    #region Usings
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using SA.GA.Business.Services;
    using SA.GA.Common.Models;
    #endregion

    [Route("api/history")]
    public class HistoryController : Controller
    {
        private readonly IHistoryService _historyService;

        public HistoryController( IHistoryService historyService)
        {
            _historyService = historyService;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            History history = _historyService.GetHistorysList().FirstOrDefault(x => x.Id == id);
            if (history != null)
            {
                _historyService.DeleteHistoryByHistoryId(id);
            }
            return Ok(history);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]History history)
        {
            if (ModelState.IsValid)
            {
                _historyService.UpdateHistoryt(history);
                return Ok(history);
            }
            return BadRequest(ModelState);
        }

        [HttpPost]
        public IActionResult Post([FromBody]History history)
        {
            if (ModelState.IsValid)
            {
                _historyService.SaveHistory(history);
                return Ok(history);
            }
            return BadRequest(ModelState);
        }

        [HttpGet("{id}")]
        public History Get(int id)
        {
            History history = _historyService.GetHistoryById(id);
            return history;
        }

        [HttpGet]
        public IEnumerable<History> Get()
        {
            return _historyService.GetHistorysList();
        }
    }
}