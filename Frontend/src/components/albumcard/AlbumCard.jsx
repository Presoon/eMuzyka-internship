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
          <p className="">
            Artysta: <strong>{props.album.artistName}</strong>
          </p>
          <p className="">
            Data wydania:{" "}
            <strong>{props.album.releaseDate.substring(0, 4)}</strong>
          </p>
          <p className="">
            Wersja: <strong>{props.album.version}</strong>
          </p>
        </div>

        <div className="buyrow">
          <button className="info-btn">SZCZEGÓŁY</button>
        </div>
      </div>
    </>
  );
};

export default AlbumCard;
