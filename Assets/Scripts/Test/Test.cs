using System;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public List<Student> students = new List<Student>();

    void Start()
    {
        Debug.Log("Start");
        students.Add(new Student("Kevin", 12));
        students.Add(new Student("Tracy", 15));
        students.Add(new Student("Oliver", 18));
        students.Add(new Student("Tania", 10));

        students.Sort();

        //foreach(Student stud in students)
        //{
            Debug.Log(message: $" L'élève le plus agé est {students[0].name} ");
        //}
        
    }


}


