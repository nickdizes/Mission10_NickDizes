import { useEffect, useState } from 'react';
import { BowlerResponse } from '../Types/BowlerResponse';

function FormatName(fName: string, mInitial: string | null, lName: string) {
  var formattedName = '';
  if (mInitial) {
    formattedName = `${fName} ${mInitial}. ${lName}`;
  } else {
    formattedName = `${fName} ${lName}`;
  }
  return formattedName;
}

function BowlerList() {
  const [bowlerData, setBowlerData] = useState<BowlerResponse[]>([]);

  useEffect(() => {
    const fetchBowlerData = async () => {
      const rsp = await fetch('http://localhost:5075/api/BowlingLeague');
      const b = await rsp.json();
      setBowlerData(b);
    };
    fetchBowlerData();
  }, []);

  return (
    <>
      <div className="row">
        <h4 className="text-center">Bowler List</h4>
      </div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Bowler Name</th>
            <th>Team Name</th>
            <th>Address</th>
            <th>Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {bowlerData.map((b) => (
            <tr key={b.bowlerId}>
              <td>
                {FormatName(
                  b.bowlerFirstName,
                  b.bowlerMiddleInit,
                  b.bowlerLastName,
                )}
              </td>
              <td>{b.teamName}</td>
              <td>
                {b.bowlerAddress} {b.bowlerCity}, {b.bowlerState} {b.bowlerZip}
              </td>
              <td>{b.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlerList;
