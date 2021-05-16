import React from "react";
import "./AlbumCard.css";

const AlbumCard = (props) => {
  return (
    <>
      <div className="albumcard">
        <div className="topcontainer">
          <img
            className="cover"
            src="https://www.muzart.pl/images/the-dark-side-of-the-moon-b-iext35454968.jpg"
            alt="album-cover"
          />
          <p className="desc">{props.album.title}</p>
          <p className="">{props.album.artistName}</p>
          <p className="">{props.album.releaseDate.substring(0, 4)}</p>
          <p className="">{props.album.version}</p>
        </div>

        <div className="buyrow">
          <button className="info-btn">SZCZEGÓŁY</button>
        </div>
      </div>
    </>
  );
};

export default AlbumCard;
