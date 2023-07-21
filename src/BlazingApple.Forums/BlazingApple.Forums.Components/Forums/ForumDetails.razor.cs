﻿using BlazingApple.Forums.Shared.Models.Forums;
using BlazingApple.Forums.Shared.Models.Threads;
using Microsoft.AspNetCore.Components;

namespace BlazingApple.Forums.Components.Forums;

/// <summary>Details about a forum.</summary>
public partial class ForumDetails : ComponentBase
{
	/// <summary>List of threads to render.</summary>
	[Parameter, EditorRequired]
	public List<IForumThread>? Threads { get; set; }

	/// <summary>Forum details to render.</summary>
	[Parameter, EditorRequired]
	public IForum? Forum { get; set; }
}