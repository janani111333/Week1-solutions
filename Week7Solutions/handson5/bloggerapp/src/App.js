import React from 'react';
import './App.css';
import BookDetails from './components/BookDetails';
import CourseDetails from './components/CourseDetails';
import BlogDetails from './components/BlogDetails';

function App() {
  const showBooks = true;
  const showCourses = false;
  const showBlogs = true;

  return (
    <div className="app-container">
      {showBooks && (
        <div className="st2">
          <h1>Book Details</h1>
          <BookDetails />
        </div>
      )}

      {showBlogs ? (
        <div className="v1">
          <h1>Blog Details</h1>
          <BlogDetails />
        </div>
      ) : (
        <p>No blog details available.</p>
      )}

      {showCourses && (
        <div className="mystyle1">
          <h1>Course Details</h1>
          <CourseDetails />
        </div>
      )}
    </div>
  );
}

export default App;
