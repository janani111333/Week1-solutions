import React, { useState } from 'react';

const CurrencyConvertor = () => {
  const [rupees, setRupees] = useState('');
  const [euros, setEuros] = useState(null);

  const handleSubmit = (e) => {
    e.preventDefault();
    const converted = parseFloat(rupees) / 90; // Example conversion rate
    setEuros(converted.toFixed(2));
  };

  return (
    <div>
      <form onSubmit={handleSubmit}>
        <label>Rupees: </label>
        <input
          type="number"
          value={rupees}
          onChange={(e) => setRupees(e.target.value)}
        />
        <button type="submit">Convert</button>
      </form>
      {euros && <p>Euro: €{euros}</p>}
    </div>
  );
};

export default CurrencyConvertor;
