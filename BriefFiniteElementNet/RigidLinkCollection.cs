﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BriefFiniteElementNet
{
    [Obsolete("Un usable")]
    public class RigidLinkCollection : List<RigidLink>
    {
        /// <summary>
        /// The parent
        /// </summary>
        [NonSerialized]
        private Model parent;

        /// <summary>
        /// Gets or sets the parent.
        /// </summary>
        /// <value>
        /// The parent.
        /// </value>
        internal Model Parent
        {
            get { return parent; }
            set { parent = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElementCollection" /> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        internal RigidLinkCollection(Model parent)
        {
            this.parent = parent;
        }
    }
}
