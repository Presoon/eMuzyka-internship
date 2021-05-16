import React from "react";
import "./AlbumWideCard.css";

const AlbumWideCard = (props) => {
  return (
    <>
      <div className="albumwidecard container ">
        <div className="row">
          <div className="col-md-6 col-sm-12">
            <div className="row p-3">
              <img
                className="cover mx-auto"
                src={props.album.cover}
                alt="album-cover"
              />
            </div>
          </div>

          <div className="col-md-6 col-sm-12 ">
            <div className="row p-4 h-100 align-items-center">
              <div>
                <p className="title">{props.album.title}</p>
                <p>
                  Artysta: <strong>{props.album.artistName}</strong>
                </p>
                <p>
                  Data wydania:
                  <strong>
                    &nbsp;
                    {props.album.releaseDate &&
                      props.album.releaseDate.toString().substring(0, 4)}
                  </strong>
                </p>
                <p>
                  Wersja: <strong>{props.album.version}</strong>
                </p>
                <p>
                  Liczba tracków:&nbsp;
                  <strong>
                    {props.album.tracks && props.album.tracks.length}
                  </strong>
                </p>
              </div>
            </div>
          </div>
        </div>
      </div>
    </>
  );
};

export default AlbumWideCard;
