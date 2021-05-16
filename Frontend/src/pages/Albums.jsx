import "../assets/css/App.css";
import API from "../services/APIcontext";
import AlbumCard from "../components/Albumcard/AlbumCard";
import React, { useEffect, useState } from "react";

const Albums = () => {
  const [albums, setAlbums] = useState([]);
  const [search, setSearch] = useState("");
  useEffect(() => {
    const fetchData = async () => {
      const result = await API.getAllAlbums().catch((err) => {
        console.error(err);
        var data = 0;
        return data;
      });
      setAlbums(result.data);
    };

    fetchData();
  }, []);

  return (
    <div className="container">
      <div className="row">
        <h1 className="titlex position-relative mt-5 mt-5 mb-5 ">
          Twoje albumy
        </h1>
      </div>
      <div className="row">
        <div className="input-group mb-3">
          <div className="input-group-prepend">
            <span className="input-group-text" id="basic-addon1">
              Wyszukaj
            </span>
          </div>
          <input
            type="text"
            className="form-control"
            placeholder="Wpisz wyszukiwaną frazę (tytuł/artystę/rok)"
            aria-label="Wyszukaj"
            onChange={(e) => setSearch(e.target.value.toLowerCase())}
          />
        </div>
      </div>
      <div className="row justify-content-center">
        {albums &&
          albums.map((album) => {
            if (
              album.title.toLowerCase().includes(search) ||
              album.artistName.toLowerCase().includes(search) ||
              album.releaseDate.toLowerCase().includes(search)
            ) {
              return <AlbumCard key={album.id} album={album} />;
            } else return null;
          })}
      </div>
    </div>
  );
};

export default Albums;
