using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace GHNY.ADC
{
    [DisplayName("待办事项表")]
    public class TodoItem : BasicAggregateRoot<Guid>
    {

        [DisplayName("待办事项")]
        public string Text { get; set; }
    }
}
