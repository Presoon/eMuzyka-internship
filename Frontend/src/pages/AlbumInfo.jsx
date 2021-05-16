import "../assets/css/App.css";
import React, { useState, useEffect } from "react";
import { useParams } from "react-router-dom";
import API from "../services/APIcontext.js";
import AlbumWideCard from "../components/AlbumWideCard/AlbumWideCard";
import AlbumTrackList from "../components/AlbumTrackList/AlbumTrackList";

const AlbumInfo = (props) => {
  const { id } = useParams();
  const [album, setAlbum] = useState([]);

  useEffect(() => {
    const fetchData = async () => {
      const result = await API.getAlbumInfoWithTracks(id).catch((err) => {
        console.error(err);
        var data = 0;
        return data;
      });
      setAlbum(result.data);
    };

    fetchData();
  }, [id]);

  return (
    <div className="container">
      <div className="row">
        <h1 className="titlex position-relative mt-5 mt-5 mb-5 ">
          Informacje o albumie
        </h1>
      </div>
      <div className="row">
        {album && (
          <>
            <AlbumWideCard album={album} />
            <AlbumTrackList tracks={album.tracks} />
          </>
        )}
      </div>
    </div>
  );
};

export default AlbumInfo;
