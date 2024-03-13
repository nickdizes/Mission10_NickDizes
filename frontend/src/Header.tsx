import logo from './BowlingLogo.png';

function Header() {
  return (
    <header className="row navbar navbar-dark bg-dark">
      <div className="col-4">
        <img src={logo} className="logo" alt="logo" />
      </div>
      <div className="col subtitle">
        <h1 className="text-white">The Best Bowling Webpage!</h1>
      </div>
    </header>
  );
}

export default Header;
