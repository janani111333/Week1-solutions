import React from 'react';
import './styles.css';

export const OfficeList = () => {
  const officeSpaces = [
    {
      name: 'Workspace One',
      rent: 50000,
      address: '1st Floor, Alpha Tower, Bangalore',
      image: 'https://www.dgicommunications.com//wp-content//uploads//2022//08//Design_a_Flexible_Workspace.jpg/300x200',
    },
    {
      name: 'Tech Hub',
      rent: 65000,
      address: 'Plot 7, Sector 2, Hyderabad',
      image: 'https://tse3.mm.bing.net//th//id//OIP.irM5Dfgzj1Jos_cKHnesvwHaEK?rs=1&pid=ImgDetMain&o=7&rm=3/300x200',
    },
    {
      name: 'Creative Studio',
      rent: 45000,
      address: '3rd Avenue, Chennai',
      image: 'https://mir-s3-cdn-cf.behance.net//project_modules/fs//ee45f2150704043.62fea98b39965.jpg/300x200',
    },
  ];

  const getColorClass = (rent) => (rent <= 60000 ? 'textRed' : 'textGreen');

  return (
    <div>
      <h1>Office Space Rental Details</h1>
      {officeSpaces.map((item, index) => (
        <div key={index} className="office-container">
          <img src={item.image} alt={item.name} width="300" height="200" />
          <h2>{item.name}</h2>
          <p>Address: {item.address}</p>
          <p className={getColorClass(item.rent)}>Rent: ₹{item.rent}</p>
        </div>
      ))}
    </div>
  );
};
