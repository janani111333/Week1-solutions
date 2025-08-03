import React from 'react';

const SyntheticEventExample = () => {
  const handleClick = (event) => {
    alert("I was clicked");
    console.log("Synthetic Event: ", event);
  };

  return (
    <div>
      <button onClick={handleClick}>Click Me</button>
    </div>
  );
};

export default SyntheticEventExample;
