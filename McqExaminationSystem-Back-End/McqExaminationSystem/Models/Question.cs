﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace McqExaminationSystem.Models;

[Table("Question")]
public partial class Question
{
    [Key]
    public int QuestionId { get; set; }

    [Required]
    [StringLength(200)]
    public string QuestionHeader { get; set; }

    [Required]
    [StringLength(200)]
    public string QuestionFirstChoice { get; set; }

    [Required]
    [StringLength(200)]
    public string QuestionSecondChoice { get; set; }

    [Required]
    [StringLength(200)]
    public string QuestionThirdChoice { get; set; }

    [Required]
    [StringLength(200)]
    public string QuestionFourthChoice { get; set; }

    [Required]
    [StringLength(200)]
    public string RightAnswer { get; set; }

    public int ExamId { get; set; }

    [DefaultValue(false)]
    public bool IsDeleted { get; set; }

    [ForeignKey("ExamId")]
    [InverseProperty("Questions")]
    public virtual Exam Exam { get; set; }
}