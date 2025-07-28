// src/Posts.js
import React from "react";
import Post from "./Post";

class Posts extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      posts: [],
      error: null
    };
  }

 loadPosts() {
  const samplePosts = [
    new Post(1, "React Lifecycle", "Understanding componentDidMount and componentDidCatch."),
    new Post(2, "Error Boundaries", "React lets you handle unexpected rendering issues."),
    new Post(3, "Using Fetch API", "You can fetch posts from APIs using fetch()."),
    new Post(4, "JSX Syntax", "JSX lets you write HTML in JavaScript."),
    new Post(5, "React Components", "Class-based and functional components make React powerful.")
  ];
  this.setState({ posts: samplePosts });
}


  componentDidMount() {
    this.loadPosts();
  }

  componentDidCatch(error, info) {
    console.error("Caught error:", error);
    console.info("Error info:", info);
    alert("Something went wrong! See console for details.");
    this.setState({ error });
  }

  render() {
    const { posts, error } = this.state;

    if (error) {
      return <div>Something went wrong: {error.toString()}</div>;
    }

    return (
      <div>
        <h2>Posts</h2>
        {posts.map((post) => (
          <div key={post.id} style={{ marginBottom: "20px" }}>
            <h3>{post.title}</h3>
            <p>{post.body}</p>
          </div>
        ))}
      </div>
    );
  }
}

export default Posts;
