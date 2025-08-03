import React from 'react';

const courses = [
  { name: 'Angular', date: '4/8/2025' },
  { name: 'React', date: '6/7/2025' }
];

export default function CourseDetails() {
  return (
    <div className="mystyle1">
      <h1>Course Details</h1>
      {courses.map((c, idx) => (
        <div key={idx}>
          <h2>{c.name}</h2>
          <p>{c.date}</p>
        </div>
      ))}
    </div>
  );
}
