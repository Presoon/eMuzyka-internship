import React from "react";
import {Link} from "react-router-dom";
import "./AlbumCard.css";

const AlbumCard = (props) => {
  return (
    <>
      <div className="albumcard">
        <div className="topcontainer">
          <img className="cover" src={props.album.cover} alt="album-cover" />
          <p className="title">{props.album.title}</p>
          <p>
            Artysta: <strong>{props.album.artistName}</strong>
          </p>
          <p>
            Data wydania:
            <strong> {props.album.releaseDate.substring(0, 4)}</strong>
          </p>
          <p>
            Wersja: <strong>{props.album.version}</strong>
          </p>
        </div>

        <div className="buyrow">
          <Link to={"/albuminfo/" + props.album.id}><button className="info-btn">SZCZEGÓŁY</button></Link>
        </div>
      </div>
    </>
  );
};

export default AlbumCard;
