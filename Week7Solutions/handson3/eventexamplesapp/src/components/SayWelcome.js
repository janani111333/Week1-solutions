import React from 'react';

const SayWelcome = () => {
  const showWelcome = (message) => {
    alert(`Message: ${message}`);
  };

  return (
    <div>
      <button onClick={() => showWelcome("Welcome!")}>Say Welcome</button>
    </div>
  );
};

export default SayWelcome;
