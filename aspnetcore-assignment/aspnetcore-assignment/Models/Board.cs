using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace aspnetcore_assignment.Models {
    /// <summary>
    /// Board Model
    /// </summary>
    public class Board {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title { get; set; }

        /// <summary>
        /// The boards todos
        /// </summary>
        /// <value>The todos.</value>
        public List<Todo> Todos { get; set; }
    }
}
