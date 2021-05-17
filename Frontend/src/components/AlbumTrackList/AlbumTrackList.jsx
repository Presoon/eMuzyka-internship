import "./AlbumTrackList.css";
import React from "react";

const AlbumTrackList = (props) => {
  const calculateDuration = (d) => {
    d = Number(d);
    var m = Math.floor((d % 3600) / 60);
    var s = Math.floor((d % 3600) % 60);
    
    var mDisplay = m > 0 ? m + ":" : "";
    var sDisplay = s > 0 ? s >= 10 ? s : "0" + s : "00";
    return mDisplay + sDisplay;
  };
  const { tracks } = props;
  return (
    <div className="container albumtracklist px-5">
      <table className="table text-center">
        <thead>
          <tr>
            <th scope="col">#</th>
            <th scope="col">Tytuł</th>
            <th scope="col">Artysta</th>
            <th scope="col">Data Wydania</th>
            <th scope="col">Czas Trwania</th>
          </tr>
        </thead>
        <tbody>
          {tracks &&
            tracks.map((track) => {
              return (
                <tr key={track.trackNumber}>
                  <th scope="row">{track.trackNumber}</th>
                  <td className="title">{track.title}</td>
                  <td>{track.artistName}</td>
                  <td>{track.releaseDate.toString().substring(0, 4)}</td>
                  <td>{calculateDuration(track.duration)}</td>
                </tr>
              );
            })}
        </tbody>
      </table>
    </div>
  );
};

export default AlbumTrackList;
