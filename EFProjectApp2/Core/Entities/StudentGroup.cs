﻿namespace EFProjectApp2.Core.Entities;

public class StudentGroup
{
    public int StudentId { get; set; }
    public int GroupId { get; set; }
    public Student Student { get; set; }
    public Group Group { get; set; }
}
