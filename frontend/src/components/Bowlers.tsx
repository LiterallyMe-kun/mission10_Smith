import { useEffect, useState } from 'react';

interface Team {
  teamName: string;
}

interface Bowler {
  bowlerId: number;
  bowlerFirstName: string;
  bowlerMiddleInit?: string;
  bowlerLastName: string;
  bowlerAddress: string;
  bowlerCity: string;
  bowlerState: string;
  bowlerZip: number;
  bowlerPhoneNumber: string;
  team: Team;
}

function BowlerTable() {
  const [bowlers, setBowlers] = useState<Bowler[]>([]);

  useEffect(() => {
    fetch("https://localhost:5000/api/home")
      .then((res) => res.json())
      .then((data) => setBowlers(data))
      .catch((err) => console.error("Error fetching bowlers:", err));
  }, []);

  return (
    <div style={{ padding: "1rem" }}>
      <h2>Bowlers from Marlins and Sharks</h2>
      <table style={{ width: "100%", borderCollapse: "collapse" }}>
        <thead>
          <tr>
            <th>Name</th>
            <th>Team</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone</th>
          </tr>
        </thead>
        <tbody>
          {bowlers.map((b) => (
            <tr key={b.bowlerId}>
              <td>{`${b.bowlerFirstName} ${b.bowlerMiddleInit ?? ""} ${b.bowlerLastName}`}</td>
              <td>{b.team?.teamName}</td>
              <td>{b.bowlerAddress}</td>
              <td>{b.bowlerCity}</td>
              <td>{b.bowlerState}</td>
              <td>{b.bowlerZip}</td>
              <td>{b.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default BowlerTable;
