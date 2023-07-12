// <copyright file="Subject.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

namespace FishyFlip.Models;

public class Subject
{
    [JsonConstructor]
    public Subject(Cid? cid, ATUri? uri)
    {
        this.Cid = cid;
        this.Uri = uri;
    }

    public Cid? Cid { get; }

    public ATUri? Uri { get; }
}