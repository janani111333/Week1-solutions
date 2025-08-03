import './App.css';
import { ListofPlayers } from './components/ListofPlayers';
import { OddPlayers, AllIndianPlayers } from './components/IndianPlayers';

function App() {
  const flag = false;

  return (
    <div className="App">
      {flag ? (
        <>
          <ListofPlayers />
        </>
      ) : (
        <>
          <OddPlayers players={['Rohit', 'Kohli', 'Pant', 'Hardik', 'Gill']} />
          <AllIndianPlayers />
        </>
      )}
    </div>
  );
}

export default App;
